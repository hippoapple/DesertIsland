﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagulFly : MonoBehaviour
{
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.forward;
        transform.position += dir *Time.deltaTime * speed;
    }
}
