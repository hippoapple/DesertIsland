﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFire : MonoBehaviour
{
    public GameObject bottle;
    public GameObject gauge;
    float progress=0.0f;
    public GameObject smoke;
    bool isTriggerenter = false;

    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggerenter == true)
        {
            SliderProgress();
        }
        if(gauge.gameObject.GetComponentInChildren<Slider>().value ==1)
        {
            smoke.gameObject.SetActive(false);
            fire.gameObject.SetActive(true);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="BOTTLE")
        {
            isTriggerenter = true;
            Debug.Log("BOTTLE is triggerEnter here");
            gauge.gameObject.SetActive(true);
            smoke.gameObject.SetActive(true);
            

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="BOTTLE")
        {
            isTriggerenter = false;
            gauge.gameObject.GetComponentInChildren<Slider>().value = 0f;
            gauge.gameObject.SetActive(false);
            progress = 0f;
        }
    }

    void SliderProgress()
    {
        progress += Time.deltaTime;
        gauge.gameObject.GetComponentInChildren<Slider>().value = progress;
    }

}
