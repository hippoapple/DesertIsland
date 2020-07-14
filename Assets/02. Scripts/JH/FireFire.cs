using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFire : MonoBehaviour
{
    public static int woodCount = 0;
    public GameObject firePlace;
    public GameObject rocks;
    public List<GameObject> storage = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        firePlace.gameObject.SetActive(false );
        
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("WOOD"))
        {
            if (++woodCount == 5)
            {
                DestoryWoods();
                rocks.gameObject.SetActive(false);

            }
            Debug.Log($"count = {woodCount}");
        }
    }
    void DestoryWoods()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, 1.0f, 1<<LayerMask.NameToLayer("Wood"));
        foreach(Collider coll in colls)
        {
            Destroy(coll.gameObject);
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("WOOD"))
        {
            --woodCount;
            Debug.Log($"count = {woodCount}");
        }
    }
}
