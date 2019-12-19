using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanging : MonoBehaviour
{
    public GameObject panelCorrect;
    public GameObject panelWrong;
    public GameObject player;
    // Start is called before the first frame update
    public void ChangeScene(string sceneName){ //씬 변경
        SceneManager.LoadScene(sceneName);
    }

    public void BackToGame() //press ok 하면 이제 다시 그 위치로 뺵
    {
        Vector3 position = f22.pos;
        position.y = 0.6f;
        player.transform.position = position;
        panelCorrect.gameObject.SetActive(false);
        panelWrong.gameObject.SetActive(false);

    }
    public void QuitApp(){ //어플리케이션 종료
        Application.Quit();
    }
}
