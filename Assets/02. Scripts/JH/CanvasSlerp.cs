using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSlerp : MonoBehaviour
{
    Vector3 alpha;
    Transform gamma;
    public GameObject playercanvas;
    Vector3 beta;
    // Start is called before the first frame update
    void Start()
    {
        alpha = GetComponent<Transform>().position;
        gamma = GetComponent<Transform>();
        beta =playercanvas.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //alpha = new Vector3(0, Mathf.Clamp(Time.time, 4.5f, 7.5f),0);
        gamma.position= Vector3.Slerp(gamma.position, playercanvas.transform.position, 0.01f);
        
    }
}
