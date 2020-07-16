using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPosition : MonoBehaviour
{
    BoilWater boilWater;
    public GameObject potPosition ;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BigPot"))
        {
            other.transform.position= potPosition.transform.position;
            //boilWater.BoiledWaterInPot();
        }
    }
}
