using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVoil : MonoBehaviour
{
    AudioSource audioSource;
    PotPosition potPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }    
        
    public void SrartVoil()
    {
        audioSource.Play();
    }
    public void StopVoilClass()
    {
        audioSource.Stop();
    }
}
