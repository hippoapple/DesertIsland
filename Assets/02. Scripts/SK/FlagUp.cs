using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagUp : MonoBehaviour
{
    // Start is called before the first frame update

    bool isFlagUp;


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
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    public void colliderOff()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
