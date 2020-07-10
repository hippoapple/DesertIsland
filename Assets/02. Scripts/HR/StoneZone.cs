using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneZone : MonoBehaviour
{
    /*public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 9)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public GameObject sOS2;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Stone"))
        {
            sOS2.gameObject.SetActive(true);
            sOS.gameObject.SetActive(false);
            .gameObject.SetActive(false); 
        }
    }
    */

        // tag가 Stone인게 10개 들어 온다면
        // 근데 만약 StoneZone 안에 
        // sos2가 setactive 되며
        // StoneZone 안의 tage가 Stone 인 돌멩이들이 삭제 된다.
    
    public static int count = 0 ;
    public GameObject stoneZone;
    public GameObject sOS2;
    private int stoneCount = 0;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Stone"))
        {
            if (++stoneCount == 10)
            {
                sOS2.SetActive(true);
                DestroyStones();
            }
            // Debug.Log($"count = {count}");
        }
    }

    void DestroyStones()
    {
        Collider[] colls = Physics.OverlapBox(transform.position
                                            , new Vector3(4.0f, 1.5f, 5.0f)
                                            , Quaternion.LookRotation(transform.forward)
                                            , 1<<LayerMask.NameToLayer("Stone"));
        foreach(Collider coll in colls)
        {
            Destroy(coll.gameObject);
        }
    }
}

