using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFire : MonoBehaviour
{
    public static int woodCount = 0;
    public GameObject firePlace;
    public GameObject rocks;
    public GameObject StoryCanvas;
    public List<GameObject> storage = new List<GameObject>();
    bool isFirePlaceOn;
    // Start is called before the first frame update
    void Start()
    {
        firePlace.gameObject.SetActive(false);

    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("WOOD"))
        {
            DestoryWoods(coll);
            if (++woodCount == 3)
            {
                //DestoryWoods();
                rocks.gameObject.SetActive(false);
                firePlace.gameObject.SetActive(true);
                isFirePlaceOn=true;
                StoryCanvas.SetActive(true);
                // StoryManager hintManager = GameObject.Find("HintManager").GetComponent<StoryManager>();
                // hintManager.ChangeStory();
            }
            Debug.Log($"Woodcount  =  {woodCount}");
        }
    }
    void DestoryWoods(Collider colling)
    {
        Destroy(colling, 30.0f);
        Debug.Log("test to this script");
        // Collider[] colls = Physics.OverlapSphere(transform.position, 1.0f, 1 << LayerMask.NameToLayer("Wood"));
        // foreach (Collider coll in colls)
        // {
        //     Destroy(coll.gameObject);
        // }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("WOOD") && isFirePlaceOn == false)
        {
            --woodCount;
            Debug.Log($"count(WOOD Out)  =  {woodCount}");
        }
    }
}
