using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScale : MonoBehaviour
{
    // Start is called before the first frame update
    public void PointerEnters()
    {
        GetComponent<Renderer>().material.color = Color.red;
        transform.localScale = new Vector3(0.40f, 0.4f, 0.40f);
    }
    public void PointerOuts()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }
    public void PointerEntersQuizPop()
    {
        transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
    }
    public void PointerOutsQuizPop()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
    }

}