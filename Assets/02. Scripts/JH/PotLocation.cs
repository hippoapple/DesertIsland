using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotLocation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        other.transform.position = this.transform.position;
    }
}
