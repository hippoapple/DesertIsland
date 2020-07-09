using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyWaterStep1 : MonoBehaviour
{
    public GameObject step1;
    public GameObject sea;
    public GameObject gauge;
    float progress=0.0f;
    bool isTriggerenter = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gauge.gameObject.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        gauge.gameObject.SetActive(false);

    }
}
