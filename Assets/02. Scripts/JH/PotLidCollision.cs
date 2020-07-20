using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotLidCollision : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="BigPot")
        audioSource.Play();
    }
}
