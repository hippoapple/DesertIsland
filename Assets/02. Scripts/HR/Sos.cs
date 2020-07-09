using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sos : MonoBehaviour
{
    public float speed = 1;

    void update() 
    {
        transform.position += new Vector3(0.0f, 1.2f, 0.0f) * speed * Time.deltaTime;
    }
}
    
    // 해골과 돌들이 Y축 1.2 더올라온다.


    

    // --------------------------

    // 만약 존 안에 10개의 돌이 올라온다면
    // 헬기가 소리가 들리며 헬기가 온다.
