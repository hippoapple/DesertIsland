using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RaycastClick : MonoBehaviour
{
    public int count =0;
     // private int LayerUI;

    List <string> hints;
 
 
    public Text hintText;

    void Start()
    {
       // LayerUI = 1 << LayerMask.NameToLayer("UI");
        hints = new List<string>();
       
        hintText = GameObject.Find("HintText").GetComponent<Text>();
         SetScript();
    }

    // Update is called once per frame
    void Update()
    {
        
            
           

        
    }

    public void ChangeHint()
    {
        switch(count)
        {
            case 0:
            hintText.text = hints[count];
            break;

             case 1:
            hintText.text = hints[count];
            break;

             case 2:
            hintText.text = hints[count];
            break;
             case 3:
            hintText.text = hints[count];
            break;
             case 4:
            hintText.text = hints[count];
            break;
             case 5:
            hintText.text = hints[count];
            break;
        }
    }

    public void  SetScript()
    {
        hints.Add("..?");    //0
        hints.Add("여기가 어디지...");//1
        hints.Add("섬인것같은데");//2
        hints.Add("그건 그렇고.. 너무 춥다.");//3
        hints.Add("불을 피워볼까");//3
       


    }
}
