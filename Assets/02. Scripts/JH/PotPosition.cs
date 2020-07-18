﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;

public class PotPosition : MonoBehaviour
{
    //BoilWater boilWater;
    //public GameObject potPosition ;
    public GameObject dolmenANDFire;
    public GameObject beforeFire;
    GrabMgr grabMgr;
    public GameObject gauge;
    public GameObject bubble;
    public GameObject cleanWater;
    public GameObject water;
    bool istriggerenter=false;
    bool iswateron = false;
    bool isbigwateron = false;
    float progress;
    private void Start()
    {
        dolmenANDFire.gameObject.SetActive(false);
        gauge.gameObject.SetActive(false);
        bubble.gameObject.SetActive(false);
        cleanWater.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BigPot"))
        {
            dolmenANDFire.gameObject.SetActive(true);
            beforeFire.gameObject.SetActive(false);
            //other.transform.position= potPosition.transform.position;
            istriggerenter = true;
            //boilWater.BoiledWaterInPot();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //progress를 멈추어라!!!
        if(istriggerenter ==true)
        {
            progress +=Time.deltaTime * 0.2f;
            print("progress" +  (int)progress);
        }
        if(progress> 10 && istriggerenter ==true)
        {
            gauge.gameObject.SetActive(false);
            bubble.gameObject.SetActive(false);
            if(isbigwateron ==false)
            {
                iTween.MoveBy(water, iTween.Hash("y", - 0.05f
                                                , "time", 2.5f
                                                , "easetype", iTween.EaseType.easeOutElastic
                                                , "oncompletetarget", this.gameObject));

                Destroy(water.gameObject,2.5f);
                isbigwateron = true;
            }
            istriggerenter = false;
        }
        else if(progress>5 && istriggerenter ==true)
        {
            bubble.gameObject.SetActive(true);
            cleanWater.gameObject.SetActive(true);
            if(iswateron == false)
            {
                iTween.MoveBy(cleanWater, iTween.Hash("y", 0.009f
                                                    , "time", 2.0f
                                                    , "easetype", iTween.EaseType.easeOutElastic
                                                    , "oncompletetarget", this.gameObject));
                iswateron=true;            
            }
        }
        else if(progress>0 && istriggerenter ==true)
        {
            gauge.gameObject.SetActive(true);
            gauge.gameObject.GetComponent<Slider>().value= progress;
        }
    }
}