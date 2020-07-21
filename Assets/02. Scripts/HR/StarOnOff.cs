using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarOnOff : MonoBehaviour
{
    FireFire fire1;
  
    public GameObject bottelSTAR;
    public GameObject cupSTAR;
    public GameObject flagSTAR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fire1.isFirePlaceOn ==true)
        {
            Debug.Log("이제 병별이 켜질꺼야");
            bottelSTAR.SetActive(true);
            //10 초 후
            Destroy(bottelSTAR,10.0f);
        }


        if (StartFire.isFireOn == true)
        {
            Debug.Log("이제 컵별이 켜질꺼야");
            cupSTAR.SetActive(true);
            //10 초 후
            Destroy(cupSTAR,10.0f);
        }
        

        if (DrinkWater.isDrink == true)
        {
            Debug.Log("이제 깃발별이 켜질꺼야");
            flagSTAR.SetActive(true);
            //10 초 후
            Destroy(flagSTAR,10.0f);
        }
    }
}
