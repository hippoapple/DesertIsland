using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //나는 여러 종류가 나올 것이지만 
    //아래로 내려가는 것이 기본적인 나일 것이다. 
    //나는 50의 확률은 아래로 50의 확률은 타겟방향으로 갈 것이야
    //필요한 것은 속도 방향 타겟이야
    public GameObject target;
    public GameObject explosionFactory;
    public float speed = 5;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x < -3&&transform.position.y<5)
        {
            dir = new Vector3(1, 1, 0);
        }
        else if (transform.position.x > 3&&transform.position.y<5)
        {
            dir = new Vector3(-1, 1, 0);
        }
        else if (transform.position.y>=5&&transform.position.x<-3)
        {
            dir = new Vector3(1, -1, 0);
        }
        else if (transform.position.y >= 5 && transform.position.x >3)
        {
            dir = new Vector3(-1, -1, 0);
        }
        else
        {
            if (Random.Range(0, 100) < 50)
            {
                dir = Vector3.down;
            }
            else
            {
                target = GameObject.Find("Player");
                dir = target.transform.position - transform.position;
            }
        }
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        
    }
    private void OnCollisionEnter(Collision other)
    {
        //적이 죽기 전에 뻥 효과를 보여주면서 죽고 싶다.
        //필요속성 : 폭발 공장
        //1. 폭발공장에서 폭발 생성
        GameObject explosion = Instantiate(explosionFactory);
        //2. 효과 발생 하고 싶다. (위치시킨다.)
        explosion.transform.position = transform.position;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
