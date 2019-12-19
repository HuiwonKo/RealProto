using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f22 : MonoBehaviour
{
    public AudioClip MusicClip; //효과음
    public AudioSource MusicSource;
    public GameObject player;
    public static Vector3 pos; //사용자 현재 위치 저장
    public void TeleportPlayer2()
    {
        MusicSource.clip = MusicClip; //이동시 띵 소리
        MusicSource.Play();
        //y위치는 고정되게 했습니당
        player.transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
        pos = player.transform.position;
    }
    public void TeleportResetPlayer()
    {
        player.transform.position = new Vector3(8.879857f, 0.6f, 8.545884f);
    }
   public void TeleportPlayerCloseToPortal(){
        MusicSource.clip = MusicClip; //이동시 띵 소리
        MusicSource.Play();
         player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pos = player.transform.position;
   }

    
    public void QuitApp()
    { //어플리케이션 종료
        Application.Quit();
    }
}
