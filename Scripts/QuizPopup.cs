using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizPopup : MonoBehaviour
{
    public GameObject target; //타겟은 꽃임.
    public AudioClip MusicClip; //효과음
    public AudioSource MusicSource;
   
    public AudioSource MusicSource2; //뾰로롱효ㅕ과음
    public AudioClip MusicClip2; //뾰ㅕ로롱효과음
    public GameObject player;
    public ParticleSystem Particle1;
    // Start is called before the first frame update
    private void Start()
    {
   //     scriptName = FindObjectOfType(typeof(TextTyping)) as TextTyping; //타이핑 스크립트를 찾는다.
//        scriptName.enabled = false;  //텍스트 타이핑 효과를 일단 펄스로 실행시키지 않음. 이동한 뒤에 실행시킬 것.
    }
    public void ChangeToQuiz1()
    {
        MusicSource2.clip=MusicClip2;
        MusicSource2.Play();
        Invoke("ChangeToRealQuiz1", 2);  //2초동안 딜레이를 준다. 
        Instantiate(Particle1, target.transform.position, Quaternion.identity); //파티클 효과를 그 타겟자리에서 실행하도록 함.
     
    }
    public void ChangeToRealQuiz1() 
    {
        CountScore.count--; //퀴즈를 하나 찾았으니 카운트를 내려줌.
        Destroy(target); //타겟을 제거해주고
        MusicSource.clip = MusicClip; //퀴즈 장소로 이동시 이동효과음 
        MusicSource.Play();
        player.transform.position = new Vector3(0.0f, 0.6f, -1841f); //퀴즈 장소로 이동
     
        
    }

    
}
