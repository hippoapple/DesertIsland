using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkWater : MonoBehaviour
{
    public static bool isDrink = false;
    public GameObject water;

    AudioSource drinkSound;
    public GameObject StoryCanvas;
    // Start is called before the first frame update

    private void Start()
    {
        drinkSound=GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(PotPosition.isbigwateron == true)
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BigPot" && ReadyWaterStep1.IsPotLid == true && isDrink==false)
        {
            print("빅팟 충돌");
            drinkSound.Play();
            iTween.MoveBy(water, iTween.Hash("y", - 0.05f
                                            , "time", 2.5f
                                            , "easetype", iTween.EaseType.easeOutElastic
                                            , "oncompletetarget", this.gameObject));

            Destroy(water.gameObject,2.5f);
            print("drinkSound on");
            StoryCanvas.SetActive(true);
            print("스토리 5 실행"); 
            isDrink = true;           
        }
    }
}
