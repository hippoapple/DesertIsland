using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
public class TextManager : MonoBehaviour
{    
    private SteamVR_Input_Sources hand = SteamVR_Input_Sources.Any;   
    private SteamVR_Action_Boolean tirgger = SteamVR_Actions.default_InteractUI;
      public Text [] hintmasage = new Text [4] ;

    int count;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if(tirgger.GetStateDown(hand))
        {
            ++count;
        }
    }
}