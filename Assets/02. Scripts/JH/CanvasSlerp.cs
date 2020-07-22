using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSlerp : MonoBehaviour
{
    Vector3 alpha;
    public GameObject playercanvas;
    Vector3 beta;
    // Start is called before the first frame update
    void Start()
    {
        alpha = GetComponent<Transform>().position;
        beta =playercanvas.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        alpha= Vector3.Slerp(alpha, beta, 0.01f);
        // if(beta.y>7.5f)
        // {
        //     alpha.y = 7.5f;
        // }
        // if(beta.y<4.5f)
        // {
        //     alpha.y =4.5f;
        // }
    }
}
