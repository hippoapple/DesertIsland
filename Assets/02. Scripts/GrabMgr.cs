using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GrabMgr : MonoBehaviour
{

    //컨트롤러로 잡은 물체를 저장한다.
    public Transform grabObject;
    public Transform approachObject;

    //공에 접촉했는지 여부
    public bool isTouched = false;
    public static bool isFlag = false;


    SteamVR_Input_Sources hand;
    SteamVR_Action_Boolean trigger;
    public GameObject SOS;
    public float speed = 5;
    public GameObject StoryCanvas;
    AudioSource audioSource;


    void Awake()
    {
        hand = SteamVR_Input_Sources.Any; //양손을 사용할 수 있도록 하는 변수
        trigger = SteamVR_Actions.default_InteractUI;
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (grabObject == null && isTouched == true && trigger.GetStateDown(hand))//만졌을때
        {
            grabObject = approachObject;
            grabObject.SetParent(this.transform);
            if (grabObject.GetComponent<Rigidbody>().isKinematic == false)
            {
                grabObject.GetComponent<Rigidbody>().isKinematic = true; //잡은물체의 물리엔진을 끈다,.
            }
        }
        else if (grabObject != null && trigger.GetStateUp(hand))//땔때
        {
            grabObject.SetParent(null);
            Vector3 _velocity = GetComponent<SteamVR_Behaviour_Pose>().GetVelocity();
            Vector3 _angularVelocity = GetComponent<SteamVR_Behaviour_Pose>().GetAngularVelocity();
            grabObject.GetComponent<Rigidbody>().isKinematic = false;
            grabObject.GetComponent<Rigidbody>().velocity = _velocity;
            print("_velocity  :  " + _velocity);
            grabObject.GetComponent<Rigidbody>().angularVelocity = _angularVelocity;
            Debug.Log("grapObject is null");
            grabObject = null;
            audioSource.Play();

        }
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "UnTouched" || coll.gameObject.tag == "UI" || coll.gameObject.tag == "Sea")
        {
            isTouched = false;
            return;
        }
        else
        {
            isTouched = true;
            approachObject = coll.transform;
            //grabObject = coll.transform;
        }



        if (coll.gameObject.CompareTag("Flag"))
        {
            isFlag = true;
            StoryCanvas.SetActive(true);
            SOS.transform.position = new Vector3(-0.6456904f, 10.5f, -25.36989f);
            print("스토리 6 실행");
            GameObject.Find("Flag").GetComponent<FlagUp>().colliderOff();


        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "UnTouched" || coll.gameObject.tag == "UI" || coll.gameObject.tag == "Sea")
            return;


        isTouched = false;
        approachObject = null;
    }






}
