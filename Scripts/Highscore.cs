using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    // Start is called before the first frame update
   private void Awake(){
       entryContainer=transform.Find("highscoreEntryContainer");
       entryTemplate=transform.Find("highscoreEntryTemplate");
       entryTemplate.gameObject.SetActive(false);

        float templateHeight=20f;
       for(int i=0; i<10; i++){
           Transform entryTransform=Instantiate(entryTemplate, entryContainer);
           RectTransform entryRectTransform=entryTransform.GetComponent<RectTransform>();
           entryRectTransform.anchoredPosition=new Vector2(0, -templateHeight*i);
           entryTransform.gameObject.SetActive(true);
       }
   }
}
