using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class BlackOut : MonoBehaviour
{

    float timer;
    int waitingTime;
    int waitingTime2;
    
    bool inside;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 3;
        waitingTime2 = 1;
        inside = false;

        OnEyeBlank();
    }



    public void OnEyeBlank()
    {
        print("aaa");
        SteamVR_Fade.Start(Color.black, 0.0f);
        StartCoroutine(FadeInEye());       
    }

    IEnumerator FadeInEye()
    {
        yield return new WaitForSeconds(waitingTime);
        SteamVR_Fade.Start(Color.clear, 0.3f);
        StartCoroutine(OnEyeBlank());  
    }

    public void OnEyeBlank()
    {
        yield return new WaitForSeconds(waitingTime2);
        SteamVR_Fade.Start(Color.black, 0.0f);
        StartCoroutine(FadeInEye2());       
    }

        IEnumerator FadeInEye2()
    {
        yield return new WaitForSeconds(waitingTime2);
        SteamVR_Fade.Start(Color.clear, 0.3f);
    }
}
