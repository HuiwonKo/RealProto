using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManagers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject panelCorrect;
    public GameObject panelWrong;
    public Questions[] questions;
    private static List<Questions> unansweredQuestions;
    private Questions currentQuestion;
    
    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text InfoText;

    //private float timeBetweenQuestions=1f;
    void Start(){
        panelWrong.gameObject.SetActive(false);
        panelCorrect.gameObject.SetActive(false);
        if(unansweredQuestions==null || unansweredQuestions.Count==0)
        {
            unansweredQuestions=questions.ToList<Questions>();
            //리스트로 퀘스쳔들 가져오기
        }
        SetCurrentQuestion();
     // Debug.Log(currentQuestion.fact+"is " +currentQuestion.isTrue);
    }
    void SetCurrentQuestion(){
        int randomQuestionIndex=Random.Range(0, unansweredQuestions.Count);
        currentQuestion=unansweredQuestions[randomQuestionIndex];

        factText.text=currentQuestion.fact;
        unansweredQuestions.RemoveAt(randomQuestionIndex);
        
    }
    public void TransitionToNextQuestion(){
        unansweredQuestions.Remove(currentQuestion);
        
       // yield return new WaitForSeconds(timeBetweenQuestions);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // Debug.Log("Go");
        SetCurrentQuestion();
        //panelWrong.gameObject.SetActive(false);
        //panelCorrect.gameObject.SetActive(false);
    }
    public void UserSelectTrue(){
        if(currentQuestion.isTrue){
            //Debug.Log("Correct!");

            panelCorrect.gameObject.SetActive(true);
             CountScore.score++;
        }
        else{
           // Debug.Log("Wrong!!!!!!!");
            panelWrong.gameObject.SetActive(true);
            InfoText.text=currentQuestion.info;
            }
            
        
        TransitionToNextQuestion();  
    }
    public void UserSelectFalse(){
        if(!currentQuestion.isTrue){
            //Debug.Log("Correct!");
            panelCorrect.gameObject.SetActive(true);
            CountScore.score++;
        }
        else
            {//Debug.Log("Wrong!!!!!!!");
            panelWrong.gameObject.SetActive(true);
            InfoText.text=currentQuestion.info;
            }
            TransitionToNextQuestion();
            

    }
    public void BackToGame() //press ok 하면 이제 다시 그 위치로 뺵
    {
        Vector3 position = f22.pos;
        position.y = 0.6f;
        player.transform.position = position;
        CountScore.score++;

    }
    

}
