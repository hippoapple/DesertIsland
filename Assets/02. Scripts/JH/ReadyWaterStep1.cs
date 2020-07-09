using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyWaterStep1 : MonoBehaviour
{
    //1.여기서는 큰냄비와 바닷물이 충돌을 하면 물이 생기는 것으로 한다.
    //2.작은냄비와 큰냄비가 충돌할 경우 작은 냄비가 물 위에 위치 시키도록 한다.
    //3.뚜껑이 큰냄비와 충돌할 경우 제자리에 위치 시키도록 한다.
    public GameObject step1;
    public GameObject water;
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
        if(progress >=10)
        {
            water.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Sea")
        {
            isTriggerenter = true;
            Debug.Log("see is triggerEnter here");
            gauge.gameObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        progress +=Time.deltaTime;
        //gauge.gameObject.GetComponentInChildren<Slider>().value = 0.0f;

    }
    private void OnTriggerExit(Collider other)
    {
        isTriggerenter = false;
        gauge.gameObject.SetActive(false);
        progress =0.0f;
    }
}
