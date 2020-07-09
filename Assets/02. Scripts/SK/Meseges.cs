using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meseges : MonoBehaviour
{
     float timer = 0;
     public GameObject textCanvas;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
         print(timer);

        if(timer >= 10 && FireFire.count == 0 )
        {
         
            textCanvas.SetActive(true);  
             //  timer = 0;
        }
        
    }
}
