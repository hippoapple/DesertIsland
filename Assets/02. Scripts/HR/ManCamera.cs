using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManCamera : MonoBehaviour
{
    public Transform target;        // 따라다닐 타겟 오브젝트의 Transform
    public float smoothing = 5f;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }
 
    void Update()
    {
        Vector3 targetCampos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCampos, smoothing * Time.deltaTime); 
    }
}
