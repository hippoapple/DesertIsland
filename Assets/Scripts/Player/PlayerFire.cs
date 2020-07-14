using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //나는 총알을 공장에서 만들어서 총알을 나에게 위치시킬 것이다.
    //필요속성 총알공장 총알 장착 위치
    public GameObject bulletFactory;
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            

            //총알을 만들어\
            GameObject bullet = Instantiate(bulletFactory);
            //총알을 위치시킨다.
            bullet.transform.position = firePosition.transform.position;
           
        }
    }
}
