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

    // Update is called once per frame
    void Update()
    {
        // 조건을 하나 더 주어야 할까요?
        if(potPosition.progress>=10)
        {
            audioSource.Stop();
        }
        else if(potPosition.progress>=5)
        {
            audioSource.Play();
        }
    }
}
