using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //만약 StoneZone 안에 tag가 stone인게 10개 들어 온다면
        // sos2가 setactive 되며
        // 기존sos와, 돌멩이들이 삭제 된다.
        
    }
        int count = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Stone"))
        {
            count++;
            Debug.Log("count =" + count);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Stone"))
        {
            count--;
            Debug.Log("count =" + count);
        }
    }
    

}
