using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PotPosition : MonoBehaviour
{
    BoilWater boilWater;
    public GameObject potPosition ;
    public GameObject dolmenANDFire;
    public GameObject beforeFire;
    GrabMgr grabMgr;
    private void Start()
    {
        dolmenANDFire.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BigPot"))
        {
            dolmenANDFire.gameObject.SetActive(true);
            beforeFire.gameObject.SetActive(false);
            other.transform.position= potPosition.transform.position;
            grabMgr.isTouched = false;
            grabMgr.grabObject = null;
            grabMgr.grabObject.SetParent(null);

            //boilWater.BoiledWaterInPot();
        }

    }
}
