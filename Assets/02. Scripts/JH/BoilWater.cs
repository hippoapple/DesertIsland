using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoilWater : MonoBehaviour
{
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
        gauge.gameObject.SetActive(true);
        progress+=Time.deltaTime;
        gauge.gameObject.GetComponent<Slider>().value= progress;
        if(progress>= 10)
        {
            
        }
        else if(progress>=5)
        {
            bubble.gameObject.SetActive(true);
        }
    }

}
