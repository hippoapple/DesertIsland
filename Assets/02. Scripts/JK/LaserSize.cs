using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserSize : MonoBehaviour
{
    public float maxDistance = 30.0f;   



    // Start is called before the first frame update
    void Start()
    {
        Vector3 des = new Vector3(0, 0, maxDistance);
        Vector3 origin = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = (des - origin).magnitude;
        //if (distance < 1) {
                           
            //transform.localScale += new Vector3(0.1f,0.1f,0.1f);
            //transform.localScale.x += 0.1f;
            //transform.localScale.y += 0.1f;
            //transform.localScale.z += 0.1f;
        //}   
    }
}
