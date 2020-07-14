using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //나는 얘가 한발만 나왔으면 좋겠어 언제냐면 에너미가 5보다 아래일때.
    //필요속성 에너미 타겟 속도 방향
    public float speed = 5;
    Vector3 dir;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        //만약 일정범위 안에 들어온다면 총을 한발 쏠 것이야.
        transform.position += dir * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
