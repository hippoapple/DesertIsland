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
    bool istriggerenter=false;
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
            grabMgr.isTouched = false;
            grabMgr.grabObject = null;
            grabMgr.grabObject.SetParent(null);
            istriggerenter = true;
            //boilWater.BoiledWaterInPot();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        progress+=Time.deltaTime;
        if(progress>= 10 && istriggerenter ==true)
        {
            istriggerenter = false;
            gauge.gameObject.SetActive(false);
            bubble.gameObject.SetActive(false);
        }
        else if(progress>=5 && istriggerenter ==true)
        {
            bubble.gameObject.SetActive(true);
            iTween.MoveBy(cleanWater, iTween.Hash("y", 0.055f
                                                , "time", 2.0f
                                                , "easetype", iTween.EaseType.easeOutElastic
                                                , "oncompletetarget", this.gameObject));
        }
        else if(progress>=0 && istriggerenter ==true)
        {
            gauge.gameObject.SetActive(true);
            gauge.gameObject.GetComponent<Slider>().value= progress;
        }
    }
}