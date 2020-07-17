using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagUp : MonoBehaviour
{
    // Start is called before the first frame update
    
    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
    if(timer >= 300) 
    {
        iTween.MoveBy(gameObject, iTween.Hash("y", 3.82f
                                            , "time", 2.5f
                                            , "easetype", iTween.EaseType.easeOutElastic
                                            , "oncompletetarget", this.gameObject));
    }    

    }
    

}
