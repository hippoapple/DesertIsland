using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //나는 상하 좌우로 움직일 것이다.
    //필요 속성 방향 속도
    public float speed = 5;
    Vector3 dir;

    public float minX ;
    public float maxX ;
    public float minY ;
    public float maxY ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //상하좌우로 입력받을 것이다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //방향을 정할 것이야
        dir = new Vector3(h, v, 0);
        dir.Normalize();
        //이동할 것이야
        transform.position += dir * speed * Time.deltaTime;

        //이동제한할 수 있도록 할것이야
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3.2f, 3.2f), Mathf.Clamp(transform.position.y, -4.0f, 6.0f), 0);
    }
        //아래에 피 통 닳는 것 넣을 것이야
}
