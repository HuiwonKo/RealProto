using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour
{
       public GameObject AfterFoundQuizTeleports1;
       public int Portal=0;
    public Text GateInfo;
    public GameObject FortressGateClosed;
    public GameObject PortalClickInfo;
    //public GameObject Portal;
    public static float time=0f;
    public ParticleSystem Particle1;
    public GameObject other;
    public Text status;
    public static int count;
    public static int score = 0; //문제를 얼마나 맞췄는지 스태틱으로 기록.
    // Start is called before the first frame update
    void Start()
    {   Particle1.Stop();
        Particle1.enableEmission=false;
        status = other.GetComponentInChildren<Text>(); //자식으로 있는 텍스트를 찾아서 지정해줌.
        count = 5; //찾아야할 꽃의 수.
    }

    // Update is called once per frame
    void Update()
    
    {   AfterFoundQuizTeleports1.SetActive(true);
          GateInfo.gameObject.SetActive(false);
        //Particle1.enableEmission=false;
       // Particle1.Stop();
        PortalClickInfo.SetActive(false);
        time += Time.deltaTime;
        if (count == 0)
        {
            if(Portal==0)
            {
                Particle1.enableEmission=true;
                 Particle1.Play();
                //Instantiate(Particle1, Particle1.transform.position, Quaternion.identity);
                Portal=1;
            }
            AfterFoundQuizTeleports1.SetActive(false);
            
           GateInfo.gameObject.SetActive(true);
            FortressGateClosed.SetActive(false);
            status.text = "Your Score: " + score + "\nYou Found All the Flowers! \n Let's escape Through the Portal!" + "\n Time: " + string.Format("{0:N2}", time);
           
           
           PortalClickInfo.SetActive(true);
        }
        else
        {

            status.text = "Your Score: " + score + "\n" + count + " more Flowers left!" + "\n Time: " + string.Format("{0:N2}", time);
      
        }

    }
    
}
