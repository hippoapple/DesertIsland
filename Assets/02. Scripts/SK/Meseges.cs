using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meseges : MonoBehaviour
{
    
     public GameObject Hint1_Canvas;
     public GameObject Hint2_Canvas;
     public GameObject Hint3_Canvas;
     public GameObject Hint4_Canvas;
     public GameObject Hint5_Canvas;
     public GameObject Hint6_Canvas;
     public GameObject Hint7_Canvas;
     public Slider FireSlider;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HintManager.timer += Time.deltaTime;
         print( HintManager.timer);

        if( HintManager.timer >= 10 && FireFire.count == 0 )
        {
         
           CanvasOn();
           Invoke("CanvasOff",5);
        }

         if( HintManager.timer >= 10 && FireSlider.value == 0 )
        {
         
            CanvasOn();
            Invoke("CanvasOff",5);
            HintManager.timer = 0;

        }
        
    }

    void CanvasOn()
    {
        Hint1_Canvas.SetActive(true); 
    }

    void CanvasOff()
    {
        Hint1_Canvas.SetActive(false); 
    }
}
