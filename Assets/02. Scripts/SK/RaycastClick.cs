using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class RaycastClick : MonoBehaviour
{
   
    public GameObject hintPanel1_1;
     // private int LayerUI;
    public static int clickCount = -2;
    List <string> hints;
    public TextMeshProUGUI hintText;

    public float timer;

    void Start()
    {
       // LayerUI = 1 << LayerMask.NameToLayer("UI");
        hints = new List<string>();
       
        hintText = GameObject.Find("HintText").GetComponent<TextMeshProUGUI>();
         SetScript();


    }

    // Update is called once per frame
    void Update()
    {  
       timer += Time.deltaTime;
        print(timer);
    }

    public void ChangeHint()
    {

          print(clickCount);
        switch(clickCount)
        {
            case 0:
            hintText.text = hints[clickCount];
            break;

             case 1:
                hintText.text = hints[clickCount];
            break;

             case 2:
                hintText.text = hints[clickCount];
            break;

             case 3:
                hintText.text = hints[clickCount];
            break;

             case 4:
                hintText.text = hints[clickCount];
            break;

            case 5:
               hintText.text = hints[clickCount];

            break; 

             case 6:
                hintPanel1_1.SetActive(false);
                timer =0;
                print(timer);

            break; 

        }

    }

    public void  SetScript()
    {
        hints.Add("여기가 어디지...?");    //0
        hints.Add("섬인것같은데...");//1
        hints.Add("그건 그렇고.. 너무 춥다.");//2
        hints.Add("저기 화덕에 불을 피워야겠다.");//3
        hints.Add("나무가 필요하겠지?");//4
        hints.Add("Mission 1 \n 불을 피우자 ");//4
       


    }
}
