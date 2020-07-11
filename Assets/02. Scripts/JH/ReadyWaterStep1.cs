using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyWaterStep1 : MonoBehaviour
{
    //1.여기서는 큰냄비와 바닷물이 충돌을 하면 물이 생기는 것으로 한다.
    //2.작은냄비와 큰냄비가 충돌할 경우 작은 냄비가 물 위에 위치 시키도록 한다.
    //3.뚜껑이 큰냄비와 충돌할 경우 제자리에 위치 시키도록 한다.
    public GameObject bigpot;
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
            isTriggerenter = false;
            gauge.gameObject.SetActive(false);
            progress =0.0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Sea")
        {
            water.gameObject.SetActive(true);
            isTriggerenter = true;
            Debug.Log("see is triggerEnter here");
            gauge.gameObject.SetActive(true);
            //gauge.gameObject.GetComponent<Slider>().value = progress;

        }
    }
    private void OnTriggerStay(Collider other)
    {
        progress += Time.deltaTime*0.5f;
        //여기서 물이 올라올 것이야. 0.1 정도 올라올 것인데. 이것을 상대 좌표계로 올릴 것이야 moveby로 올릴 것이고, y가 0.1만큼 올라갈 것이다.  
        iTween.MoveBy(water, iTween.Hash("y", 0.1f
                                        , "time", 2.0f
                                        , "easetype", iTween.EaseType.easeOutElastic
                                        , "oncompletetarget", this.gameObject));
    }
    private void OnTriggerExit(Collider other)
    {
        isTriggerenter = false;
        gauge.gameObject.SetActive(false);
        progress =0.0f;
    }
}
