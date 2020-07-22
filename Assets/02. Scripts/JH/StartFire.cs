using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFire : MonoBehaviour
{
    public GameObject gauge;
    public GameObject smoke;
    public GameObject fire;
    public GameObject StoryCanvas;
    float progress=0.0f;
    bool isTriggerenter = false;
    public static bool isFireOn;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource= GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggerenter == true)
        {
            SliderProgress();
        }
        
        if(progress>=10 && isTriggerenter==true)
        {
            FinishProgress();
            //progress = 0;
            isTriggerenter=false;
            audioSource.Play();
        }
        else if(progress>=5 && isTriggerenter==true)
        {
            smoke.gameObject.SetActive(true);
        }
        
    }
    
    private void OnTriggerStay(Collider other)
    {   
        if(other.gameObject.tag =="BOTTLE")
        {
            isTriggerenter = true;
           // Debug.Log("BOTTLE is triggerEnter here");
            gauge.gameObject.SetActive(true);
        }
         if(other.gameObject.tag =="BOTTLE" && isFireOn == true )
         {
            Destroy(other.gameObject);
            StoryCanvas.SetActive(true);
            StoryManager1.Dialog_Source.PlayOneShot(StoryManager1.Diralog[StoryManager1.clickCount]);

            print("스토리 3 실행");
         }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="BOTTLE")
        {
            isTriggerenter = false;
            gauge.gameObject.GetComponent<Slider>().value = 0f;
            gauge.gameObject.SetActive(false);
            progress = 0f;
        }
    }

    void SliderProgress()
    {
        if(isTriggerenter!=false)
        {
            progress += Time.deltaTime;
        }
        gauge.gameObject.GetComponent<Slider>().value = progress;
    }

    void FinishProgress()
    {
        smoke.gameObject.SetActive(false);
        fire.gameObject.SetActive(true); 
       
        isFireOn = true;
        isTriggerenter = false;
        gauge.gameObject.SetActive(false);
    }

}
