using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyWaterStep2 : MonoBehaviour
{
    //2.작은냄비와 큰냄비가 충돌할 경우 작은 냄비가 물 위에 위치 시키도록 한다.
    //3.뚜껑이 큰냄비와 충돌할 경우 제자리에 위치 시키도록 한다.
    //이것들을 새로 만드는 스피어에 적용을 하도록 한다.
    public GameObject smallCup;
    public static bool IsSmallCup; 
    public GameObject potLid;
    public static bool IsPotLid; 

    // Start is called before the first frame update
    void Start()
    {
        potLid.gameObject.SetActive(false);
        smallCup.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("SmallCup"))
        {
            Destroy(other.gameObject);
            smallCup.gameObject.SetActive(true);
            IsSmallCup = true;
        }
        if(other.gameObject.CompareTag("PotLid"))
        {
            Destroy(other.gameObject);
            potLid.gameObject.SetActive(true);
            IsPotLid=true;
            //BoilWater.BoiledWaterInPot();
        }
        
    }
}
