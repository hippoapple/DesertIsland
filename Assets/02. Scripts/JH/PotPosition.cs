using System.Collections;
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
    bool iswateron = false;
    public float progress;
    public static bool isBigpotEnter = false;
    public static bool isbigwateron = false;
    StopVoil StopVoil;
    private void Start()
    {
        dolmenANDFire.gameObject.SetActive(false);
        gauge.gameObject.SetActive(false);
        bubble.gameObject.SetActive(false);
        cleanWater.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BigPot") && ReadyWaterStep1.isWaterOn == true && ReadyWaterStep1.IsPotLid == true && ReadyWaterStep1.IsSmallCup ==true)
        {
            dolmenANDFire.gameObject.SetActive(true);
            beforeFire.gameObject.SetActive(false);
            //other.transform.position= potPosition.transform.position;
            isBigpotEnter = true;
            //boilWater.BoiledWaterInPot();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //progress를 멈추어라!!!
        if (isbigwateron == false)
        {
            progress += Time.deltaTime * 0.25f;
            print("progress" + (int)progress);
        }
        if (progress > 10 && isBigpotEnter == true)
        {
            gauge.gameObject.SetActive(false);
            bubble.gameObject.SetActive(false);
            StopVoil.StopVoilClass();
            if (isbigwateron == false)
            {
                iTween.MoveBy(water, iTween.Hash("y", -0.05f
                                                , "time", 2.5f
                                                , "easetype", iTween.EaseType.easeOutElastic
                                                , "oncompletetarget", this.gameObject));

                Destroy(water.gameObject, 2.5f);
                isbigwateron = true;
            }
            isBigpotEnter = false;
        }
        else if (progress > 7 && isBigpotEnter == true)
        {
            //오 좋네요!
            cleanWater.gameObject.SetActive(true);
            if (iswateron == false)
            {
                iTween.MoveBy(cleanWater, iTween.Hash("y", 0.009f
                                                    , "time", 2.0f
                                                    , "easetype", iTween.EaseType.easeOutElastic
                                                    , "oncompletetarget", this.gameObject));
                iswateron = true;
            }
        }
        else if (progress > 5 && isBigpotEnter == true)
        {
            bubble.gameObject.SetActive(true);
            gauge.gameObject.GetComponent<Slider>().value = progress;
            StopVoil.SrartVoil();
        }
        else if (progress > 0 && isBigpotEnter == true)
        {
            gauge.gameObject.SetActive(true);
            gauge.gameObject.GetComponent<Slider>().value = progress;
        }
    }
}