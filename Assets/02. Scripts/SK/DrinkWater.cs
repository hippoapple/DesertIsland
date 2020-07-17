using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkWater : MonoBehaviour
{
    public bool isDrink = false;
    public GameObject water;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BigPot" && ReadyWaterStep2.IsPotLid == true)
        {
            isDrink = true;
             water.gameObject.SetActive(true);


           
            iTween.MoveBy(water, iTween.Hash("y", - 0.05f
                                            , "time", 2.5f
                                            , "easetype", iTween.EaseType.easeOutElastic
                                            , "oncompletetarget", this.gameObject));

            Destroy(water.gameObject,2.5f);
        }
    }
}
