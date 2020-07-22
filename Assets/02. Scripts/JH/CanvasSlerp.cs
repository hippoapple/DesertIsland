using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSlerp : MonoBehaviour
{
    Transform alpha;
    public GameObject playercanvas;
    // Start is called before the first frame update
    void Start()
    {
        alpha = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        alpha.position = Vector3.Slerp(alpha.position, playercanvas.transform.position, 0.1f);
    }
}
