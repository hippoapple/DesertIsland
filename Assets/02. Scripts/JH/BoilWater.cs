using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoilWater : MonoBehaviour
{
    public GameObject gauge;
    bool istriggerenter=false;
    float progress;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoiledWaterInPot()
    {
        istriggerenter=true;
        //gauge.getcomponent<value>().value = progress;
    }

}
