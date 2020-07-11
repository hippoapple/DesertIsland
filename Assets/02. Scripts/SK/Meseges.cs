using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meseges : MonoBehaviour
{
    
     public GameObject Hint1_Canvas;
     public GameObject Hint2_Canvas;
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
         
            Hint1_Canvas.SetActive(true);  
            HintManager.timer = 0;
        }

         if( HintManager.timer >= 10 && FireSlider.value == 0 )
        {
         
            Hint2_Canvas.SetActive(true);  
            HintManager.timer = 0;
        }
        
    }
}
