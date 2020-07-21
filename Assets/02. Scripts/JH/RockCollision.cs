using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    AudioSource rockSound;

    // Start is called before the first frame update
    void Start()
    {
        rockSound =GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Stone")
        {
            rockSound.Play();
        }
    }
}
