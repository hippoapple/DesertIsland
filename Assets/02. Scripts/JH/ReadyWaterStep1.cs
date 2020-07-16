using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyWaterStep1 : MonoBehaviour
{
    //1.여기서는 큰냄비와 바닷물이 충돌을 하면 물이 생기는 것으로 한다.
    //1-1. 여기서는 충돌을 할 때, 물이 올라올 것이고, 게이지가 찰 것이다.

    public GameObject water;
    public static bool isWaterOn;
    public GameObject StoryCanvas;


     public GameObject smallCup;
    public static bool IsSmallCup; 
    public GameObject potLid;
    public static bool IsPotLid; 
    void Start()
    {
        water.gameObject.SetActive(false);
        potLid.gameObject.SetActive(false);
        smallCup.gameObject.SetActive(false);

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sea" &&isWaterOn ==false)
        {
            water.gameObject.SetActive(true);


            //여기서 물이 올라올 것이야. 0.1 정도 올라올 것인데. 이것을 상대 좌표계로 올릴 것이야 moveby로 올릴 것이고, y가 0.1만큼 올라갈 것이다.  
            iTween.MoveBy(water, iTween.Hash("y", 0.05f
                                            , "time", 2.0f
                                            , "easetype", iTween.EaseType.easeOutElastic
                                            , "oncompletetarget", this.gameObject));
            isWaterOn = true;
            StoryCanvas.SetActive(true);
        }

        if(other.gameObject.CompareTag("SmallCup"))
        {
            Destroy(other.gameObject);
            smallCup.gameObject.SetActive(true);
            IsSmallCup = true;
        }
        if(other.gameObject.CompareTag("PotLid"))
        {
            Destroy(other.gameObject);
            potLid.gameObject.SetActive(true);
            IsPotLid=true;
        }
    }
}

