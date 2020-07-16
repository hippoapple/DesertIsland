using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManCamera : MonoBehaviour
{
    public Transform target;        // 따라다닐 타겟 오브젝트의 Transform
 
    private Transform tr;                // 카메라 자신의 Transform
 
    void Start()
    {
        tr = GetComponent<Transform>();
    }
 
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x - 0.14f, tr.position.y + 0.95f, target.position.z - 2.08f);
 
        tr.LookAt(target);
    }
}
