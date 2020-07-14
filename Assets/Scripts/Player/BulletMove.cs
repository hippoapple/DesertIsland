using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    //여러가지 총알이 있겠지만 일단 얘는 위 방향으로 갈 것이다.
    //필요속성 속도 방향
    public float speed = 10;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.up;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
