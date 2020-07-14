using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFIre : MonoBehaviour
{
    //나는 총을 한방만 쏠꺼야!!
    //필요 에너미의 y값 총알 공장 일정 시간 경과시간
    public GameObject bulletFactory;
    public GameObject enemy;
    public float createTime = 1;
    float currentTime;
    bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        a = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //한번만 발사했니
        //만약에 너가 한번 발사를 했다면 나는 조건을 true로 바꿀꺼야
        if (a == false)
        {
            currentTime += Time.deltaTime;
            if (currentTime > createTime)
            {
                GameObject bullet = Instantiate(bulletFactory);
                bullet.transform.position = enemy.transform.position;
                currentTime = 0;
                a = true;
            }            
        }
    }
}
