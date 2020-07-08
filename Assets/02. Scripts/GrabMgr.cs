﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GrabMgr : MonoBehaviour
{

    //z컨트롤러로 잡은 물체를 저장한다.
    private Transform grabObject;

    //공에 접촉했는지 여부
    private bool isTouched = false;

    private SteamVR_Input_Sources hand = SteamVR_Input_Sources.Any;
    private SteamVR_Action_Boolean tirgger = SteamVR_Actions.default_InteractUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched == true && tirgger.GetStateDown(hand))
        {
            grabObject.SetParent(this.transform);
            grabObject.GetComponent<Rigidbody>().isKinematic = true; //잡은물체의 물리엔진을 끈다,.
        }

        if (isTouched == true && tirgger.GetStateUp(hand))
        {
            grabObject.SetParent(null);
            Vector3 _velocity = GetComponent<SteamVR_Behaviour_Pose>().GetVelocity();
            grabObject.GetComponent<Rigidbody>().isKinematic = false;
            grabObject.GetComponent<Rigidbody>().velocity = _velocity;

            isTouched = false;
            grabObject = null;
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        isTouched = true;
        if(coll.gameObject.tag=="UnTouched")
        {
            isTouched= false;
        }
        grabObject = coll.transform;        
    }
}
