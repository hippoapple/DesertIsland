using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPosition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position= new Vector3(15.26f, 10.3f, -7.74f);
    }
}
