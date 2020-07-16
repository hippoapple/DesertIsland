using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoilWater : MonoBehaviour
{
    //여기서는 물을 끓이는 것에 관해서 다룰 것이다.

    //1. 시작이 된다면 게이지가 나올 것이다.
    //2. 물을 찾아보자
    
    public GameObject gauge;
    public GameObject bubble;
    bool istriggerenter=false;
    float progress;
    
    // Start is called before the first frame update
    void Start()
    {
        gauge.gameObject.SetActive(false);
        bubble.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoiledWaterInPot()
    {
        //gauge.getcomponent<value>().value = progress;
        Invoke("startBoiledWater", 3);
    }
    void startBoiledWater()
    {
        progress+=Time.deltaTime;
        if(progress>= 10)
        {
            gauge.gameObject.SetActive(false);
            bubble.gameObject.SetActive(false);
        }
        else if(progress>=5)
        {
            bubble.gameObject.SetActive(true);
        }
        else
        {
            gauge.gameObject.SetActive(true);
            gauge.gameObject.GetComponent<Slider>().value= progress;
        }
    }
}
