using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPosition : MonoBehaviour
{
    BoilWater boilWater;
    Vector3 pos = new Vector3(15.26f, 10.3f, -7.74f);
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BigPot"))
        {
            other.transform.position= pos;
            boilWater.BoiledWaterInPot();
        }
    }
}
