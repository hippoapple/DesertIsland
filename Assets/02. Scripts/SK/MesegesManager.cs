using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MesegesManager : MonoBehaviour
{

    public GameObject bottelSTAR;
    public GameObject cupSTAR;
    public GameObject flagSTAR;
    public GameObject Hint1_Canvas;
    public GameObject Hint2_Canvas;
    public GameObject Hint3_Canvas;
    public GameObject Hint4_Canvas;
    public GameObject Hint5_Canvas;
    public GameObject Hint6_Canvas;
    public GameObject Hint7_Canvas;
    public Slider FireSlider;
    public GameObject FirePlace;

    StoryManager1 storyManager1;
    bool ishint5;
    bool isCavasOn = false;


    // Start is called before the first frame update
    void Start()
    {


        storyManager1 = GameObject.Find("HintManager1").GetComponent<StoryManager1>();
    }

    // Update is called once per frame
    void Update()
    {
        // StoryManager.timer += Time.deltaTime;
        //Debug.Log( StoryManager.timer);

        if (isCavasOn == false && StoryManager1.timer > 5 && FireFire.woodCount == 0 && StoryManager1.clickCount >= 4)
        {

            Hint1_Canvas.SetActive(true);
            Debug.Log("힌트 1 실행.");
            isCavasOn = true;
            Invoke("CanvasOff", 10);

        }

        if (isCavasOn == false && StoryManager1.timer > 10 && FireFire.woodCount >= 3 && StoryManager1.clickCount == 10)
        {

            Hint2_Canvas.SetActive(true);
            Debug.Log("힌트 2 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);

            Debug.Log("이제 병별이 켜질꺼야");
            bottelSTAR.SetActive(true);
            //10 초 후
            Destroy(bottelSTAR, 10.0f);
        }

        if (isCavasOn == false && StoryManager1.timer > 7 && StartFire.isFireOn == true && ReadyWaterStep1.isWaterOn == false)
        {
            Hint3_Canvas.SetActive(true);
            Debug.Log("힌트 3 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);

            Debug.Log("이제 컵별이 켜질꺼야");
            cupSTAR.SetActive(true);
            //10 초 후
            Destroy(cupSTAR, 10.0f);
        }

        if (isCavasOn == false && StoryManager1.timer > 7 && ReadyWaterStep1.IsSmallCup == false && ReadyWaterStep1.isWaterOn == true)
        {
            Hint4_Canvas.SetActive(true);
            Debug.Log("힌트 4 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);
        }

        if (isCavasOn == false && ReadyWaterStep1.IsSmallCup == true && ishint5 == false)
        {

            Hint5_Canvas.SetActive(true);
            Debug.Log("힌트 5 실행.");
            isCavasOn = true;

        }
        if (isCavasOn == true && ReadyWaterStep1.IsSmallCup == true && PotPosition.isBigpotEnter == true && ishint5 == false)
        {

            Hint5_Canvas.SetActive(false);
            Debug.Log("힌트 5 끔.");
            isCavasOn = false;
            ishint5 = true;
            storyManager1.StopAllCoroutines();

        }

        if (isCavasOn == false  && StoryManager1.timer > 20 && GrabMgr.isFlag == false && ReadyWaterStep1.IsPotLid == true)
        {
            Hint6_Canvas.SetActive(true);
            Debug.Log("힌트 6 실행.");
            isCavasOn = true;
            Invoke("CanvasOff", 10);
            Debug.Log("이제 깃발별이 켜질꺼야");
            flagSTAR.SetActive(true);
            //10 초 후
            Destroy(flagSTAR, 10.0f);
        }

        if (isCavasOn == false && StoryManager1.timer > 7 && StoneZone.stoneCount < 3 && GrabMgr.isFlag == true)
        {
            Hint7_Canvas.SetActive(true);
            Debug.Log("힌트 7 실행.");
            isCavasOn = true;
            Invoke("CanvasOff", 10);
        }


    }


    void CanvasOff()
    {


        Hint1_Canvas.SetActive(false);
        Debug.Log("1꺼짐.");

        Hint2_Canvas.SetActive(false);
        Debug.Log("2꺼짐");

        Hint3_Canvas.SetActive(false);
        Debug.Log("3꺼짐");

        Hint4_Canvas.SetActive(false);
        Debug.Log("4꺼짐");

        Hint5_Canvas.SetActive(false);
        Debug.Log("5꺼짐");

        Hint6_Canvas.SetActive(false);
        Debug.Log("6꺼짐");

        Hint7_Canvas.SetActive(false);
        Debug.Log("7꺼짐");


        isCavasOn = false;
        storyManager1.StopAllCoroutines();
        StoryManager1.timer = 0;
    }




}