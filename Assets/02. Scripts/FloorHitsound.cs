using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorHitsound : MonoBehaviour
{

    AudioSource woodSound;
    AudioSource branchSound;
    AudioSource canSound;
    
    // Start is called before the first frame update
    void Start()
    {
        woodSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Wood")
        {
            
        }
    }
}
