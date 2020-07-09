using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public float speed = 1;
 
    //생성될 Prefab
    public GameObject sOS;
    //Prefab 생성위치
    public Transform sosPosition;

    void Start() 
    {
      
    }
    
    // 만약 깃발을 잡으면 = 부딪히면
    // SOS 가 해골과 돌들이 Y축 1.2 더올라온다.


    public void SosMake()
    {
        Instantiate(sOS, sosPosition.position, Quaternion.identity);
    }
           
      
    
}

    // --------------------------

    // 만약 존 안에 10개의 돌이 올라온다면
    // 헬기가 소리가 들리며 헬기가 온다.
