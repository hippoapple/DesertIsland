using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneZone : MonoBehaviour
{
        // tag가 Stone인게 10개 들어 온다면
        // 근데 만약 StoneZone 안에 
        // sos2가 setactive 되며
        // StoneZone 안의 tage가 Stone 인 돌멩이들이 삭제 된다.
    
    
    public GameObject stoneZone;
    public GameObject sOS2;
    public GameObject tweenMgr;
    public static int stoneCount = 0;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Stone"))
        {
            if (++stoneCount == 3) // 추후 10개로 하자. 10개 일단은 너무 많은듯 ㅠ
            {
                sOS2.SetActive(true);
                tweenMgr.SetActive(true);
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

    // 만약 존 안에 10개의 돌이 올라온다면
    // Prefabs SOS2가 생기고, 기존의 10 개 돌이 사라진다.
    // 헬기가 소리가 들리며 헬기가 온다.
