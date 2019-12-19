using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Go321 : MonoBehaviour
{
    // Start is called before the first frame update
    public float LimitTime;
    public Text text_Timer;

    // Update is called once per frame
    void Update()
    {
        LimitTime-=Time.deltaTime;
        text_Timer.text=" "+Mathf.Round(LimitTime);
        if(Mathf.Round(LimitTime)<0){
            text_Timer.text="Go!";
        }
    }
}
