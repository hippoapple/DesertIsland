using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFire : MonoBehaviour
{
    int count = 0 ;
    public GameObject firePlace;
    public GameObject rocks;
    public GameObject wood;
    public List<GameObject> storage = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        firePlace.gameObject.SetActive(false );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag =="WOOD")
        {
            count+=1;
            Debug.Log($"count = {count}");
            storage.Add(other.gameObject);
        }
        
        if(count==3)
        {
            firePlace.gameObject.SetActive(true);
            rocks.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            for( int i = 0; i < storage.Count; i++)
            {
                storage[i].SetActive(false);
            }
        }
    }
}
