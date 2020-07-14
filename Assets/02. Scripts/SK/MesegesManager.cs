using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MesegesManager : MonoBehaviour
{   
    public static MesegesManager instance;
    
     public GameObject Hint1_Canvas;
     public GameObject Hint2_Canvas;
     public GameObject Hint3_Canvas;
     public GameObject Hint4_Canvas;
     public GameObject Hint5_Canvas;
     public GameObject Hint6_Canvas;
     public GameObject Hint7_Canvas;
     public Slider FireSlider;
    public GameObject FirePlace;
   private void Awake()
   {
       instance = this;
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // StoryManager.timer += Time.deltaTime;
         //print( StoryManager.timer);

        if( StoryManager.timer > 60 && FireFire.count == 0 )
        {
           Hint1_Canvas.SetActive(true); 
           Invoke("CanvasOff",5);
        }

         if( StoryManager.timer >= 60 && FireSlider.value == 0 && FireFire.woodcount ==3);
        {
         
            Hint2_Canvas.SetActive(true); 
            Invoke("CanvasOff",5);
            // StoryManager.timer = 0;
        }
        
    }

    void CanvasOn()
    {
      
    }

    void CanvasOff()
    {
        Hint1_Canvas.SetActive(false); 
        Hint2_Canvas.SetActive(false); 
        Hint3_Canvas.SetActive(false); 
        Hint4_Canvas.SetActive(false); 
        Hint5_Canvas.SetActive(false); 
        Hint6_Canvas.SetActive(false); 
    }
}
