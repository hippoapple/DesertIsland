using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sos : MonoBehaviour
{
    public GameObject SOS;
    public float speed = 1;
    
    void update()
    {
        SOS.transform.position += new Vector3(0.0f, 1.2f, 0.0f) * speed * Time.deltaTime;
    }
}
    
    // 해골과 돌들이 Y축 1.2 더올라온다.
    // private void OnTriggerEnter(Collider other)
    // {
    //     SOS.transform.position += new Vector3(0.0f, 1.2f, 0.0f) * speed * Time.deltaTime;
    // }   

