using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GrabMgr : MonoBehaviour
{

    //컨트롤러로 잡은 물체를 저장한다.
    private Transform grabObject;

    //공에 접촉했는지 여부
    private bool isTouched = false;

  
    SteamVR_Input_Sources hand;
    SteamVR_Action_Boolean tirgger;
    public GameObject SOS;
    public float speed = 5;

    void Awake()
    {
        hand = SteamVR_Input_Sources.Any; //양손을 사용할 수 있도록 하는 변수
        tirgger = SteamVR_Actions.default_InteractUI;
    }

 
    // Update is called once per frame
    void Update()
    {
        if (isTouched == true && tirgger.GetStateDown(hand))//만졌을때
        {
            grabObject.SetParent(this.transform);
            grabObject.GetComponent<Rigidbody>().isKinematic = true; //잡은물체의 물리엔진을 끈다,.
        }

        if (isTouched == true && tirgger.GetStateUp(hand))//땔때
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
        if(coll.gameObject.tag=="UnTouched"||coll.gameObject.tag=="UI")
        {
            isTouched= false;
        }
        grabObject = coll.transform;  
        if (coll.gameObject.CompareTag ("Flag"))
        {
         SOS.transform.position = new Vector3(-0.6456904f, 10.5f, -25.36989f) ;
	    }
    }
        

 

   

}
