using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RaycastClick : MonoBehaviour
{

    RaycastHit hit;
    float distance =50.0f;
    public int count =0;
     private int LayerUI = 1 << LayerMask.NameToLayer("UI");

    List <string> hints;
 
 
    public Text hintText;
    void Start()
    {
        hints = new List<string>();
       
        hintText = GameObject.Find("HintText").GetComponent<Text>();
         SetScript();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward, out hit, distance, LayerUI))
        {
              ++count;
              ChangeHint();


        }
    }

    public void ChangeHint()
    {
        switch(count)
        {
            case 0:
            hintText.text = hints[count];
            break;
        }
    }

    public void  SetScript()
    {
        hints.Add("..?");    //0
        hints.Add("여기가 어디지...");//1
        hints.Add("섬인것같은데");//2
        hints.Add("그건 그렇고.. 너무 춥다.");//2
       


    }
}
