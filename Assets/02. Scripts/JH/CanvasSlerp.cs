using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSlerp : MonoBehaviour
{
    Transform alpha;
    public GameObject playercanvas;
    Vector3 beta;
    // Start is called before the first frame update
    void Start()
    {
        alpha = GetComponent<Transform>();
        beta =playercanvas.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        alpha.position = Vector3.Slerp(alpha.position, playercanvas.transform.position, 0.01f);
        if(playercanvas.transform.position.y>7.5f)
        {
            //beta.y =
        }
    }
}
