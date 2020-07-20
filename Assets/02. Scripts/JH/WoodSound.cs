using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSound : MonoBehaviour
{
    AudioSource woodColl;
    // Start is called before the first frame update
    void Start()
    {
        woodColl = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="WOOD")
        {
            woodColl.Play();
        }
    }
}
