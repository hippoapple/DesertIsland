using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGOD : MonoBehaviour
{
    //나는 에너미를 경과시간이 일정시간을 초과하면 공장에서 생성하여 위치 시킬 것이다.
    //필요속성 에너미 공장 일정시간 경과시간
    public GameObject enemyFactory;
    public float createTime = 2;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //먼저 경과시간은 0으로 시작하고
        currentTime += Time.deltaTime;
        //경과시간이 일정시간 지나면 위치시킬 것이다.
        if (currentTime> createTime )
        {
            //경과 시간을 0으로 초기화 시켜주고
            currentTime = 0;
            //에너미를 에너미공장에서 생산해서
            GameObject enemy = Instantiate(enemyFactory);
            //에너미를 위치시킬 것이야
            enemy.transform.position = transform.position;
        }
        
    }
}
