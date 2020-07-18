using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MesegesManager : MonoBehaviour
{

    public GameObject Hint1_Canvas;
    public GameObject Hint2_Canvas;
    public GameObject Hint3_Canvas;
    public GameObject Hint4_Canvas;
    public GameObject Hint5_Canvas;
    public GameObject Hint6_Canvas;
    public GameObject Hint7_Canvas;
    public Slider FireSlider;
    public GameObject FirePlace;

    StoryManager storyManager;
    bool ishint5;
    bool isCavasOn = false;
    // Start is called before the first frame update
    void Start()
    {


        storyManager = GameObject.Find("HintManager").GetComponent<StoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // StoryManager.timer += Time.deltaTime;
        //Debug.Log( StoryManager.timer);

        if (isCavasOn == false && StoryManager.timer > 5 && FireFire.woodCount == 0 && StoryManager.clickCount >= 6)
        {

            Hint1_Canvas.SetActive(true);
            Debug.Log("힌트 1 실행.");
            isCavasOn = true;
            Invoke("CanvasOff", 10);

        }

        if (isCavasOn == false && StoryManager.timer > 10 && FireFire.woodCount >= 3 && StoryManager.clickCount == 11)
        {

            Hint2_Canvas.SetActive(true);
            Debug.Log("힌트 2 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);
        }

        if (isCavasOn == false && StoryManager.timer > 7 && StartFire.isFireOn == true && ReadyWaterStep1.isWaterOn == false)
        {
            Hint3_Canvas.SetActive(true);
            Debug.Log("힌트 3 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);
        }

        if (isCavasOn == false && StoryManager.timer > 7 && ReadyWaterStep1.IsSmallCup == false && ReadyWaterStep1.isWaterOn == true)
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


        }

        if (isCavasOn == false && StoryManager.timer > 7 && GrabMgr.isFlag == false && ReadyWaterStep1.IsPotLid == true)
        {
            Hint6_Canvas.SetActive(true);
            Debug.Log("힌트 6 실행.");

            isCavasOn = true;
            Invoke("CanvasOff", 10);
        }

        if (isCavasOn == false && StoryManager.timer > 7 && StoneZone.stoneCount < 3 && GrabMgr.isFlag == true)
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
        storyManager.StopAllCoroutines();
        StoryManager.timer = 0;
    }




}