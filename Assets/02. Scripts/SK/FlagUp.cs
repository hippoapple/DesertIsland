using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagUp : MonoBehaviour
{
    // Start is called before the first frame update

    bool isFlagUp;
 

    private void Start()
    {
       
        
    }
    private void Update()
    {


        if (DrinkWater.isDrink == true && isFlagUp == false)
        {
            iTween.MoveBy(gameObject, iTween.Hash("y", 3.82f
                                                , "time", 2.5f
                                                , "easetype", iTween.EaseType.easeOutElastic
                                                , "oncompletetarget", this.gameObject));

            isFlagUp = true;
            Invoke("colliderOn", 1f);
            


        }

    }

    void colliderOn()
    {//위에서 invoke 함수 안에서 선언함.
        gameObject.GetComponent<BoxCollider>().enabled = true;
       
    }

    public void colliderOff()
    {
        Destroy(gameObject,2.0f);
        //this.GetComponent<BoxCollider>().enabled = false;
    }
}
