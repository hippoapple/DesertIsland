using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPosition : MonoBehaviour
{
    BoilWater boilWater;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position= new Vector3(15.26f, 10.3f, -7.74f);
        boilWater.BoiledWaterInPot();
    }
}
