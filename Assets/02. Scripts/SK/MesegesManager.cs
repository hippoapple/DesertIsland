﻿using System.Collections;
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
        //print( StoryManager.timer);

        if (isCavasOn == false && storyManager.timer > 5 && FireFire.woodCount == 0)
        {
            Debug.Log("실행");

            Hint1_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);

        }

        if (isCavasOn == false && StoryManager.timer > 5 && FireFire.woodCount == 5)
        {
            Debug.Log("뭐라도 되라!!");
            Hint2_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }
        
         if (isCavasOn == false && StoryManager.timer > 5 && ReadyWaterStep1.progress == 0.0F)
        {
            Hint3_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }

         if (isCavasOn == false && StoryManager.timer > 5 && ReadyWaterStep2.IsSmallCup == false )
        {
            Hint4_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }

         if (isCavasOn == false && StoryManager.timer > 5 && ReadyWaterStep2.IsPotLid == false)
        {
            Hint5_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }

          if (isCavasOn == false && StoryManager.timer > 5 && GrabMgr.isFlag == false)
        {
            Hint6_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }

  if (isCavasOn == false && StoryManager.timer > 5 && StoneZone.stoneCount < 3 )
        {
            Hint7_Canvas.SetActive(true);
            isCavasOn = true;
            Invoke("CanvasOff", 5);
        }


    }


    void CanvasOff()
    {
        Debug.Log("이것도 실행 될까?");
        print("에잉");
        //isCavasOn = false;
        Hint1_Canvas.SetActive(false);
        print("1꺼짐");
        Hint2_Canvas.SetActive(false);
        //print("2꺼짐");
        Hint3_Canvas.SetActive(false);
        //print("3꺼짐");
        Hint4_Canvas.SetActive(false);
        //print("4꺼짐");
        Hint5_Canvas.SetActive(false);
        //print("5꺼짐");
        Hint6_Canvas.SetActive(false);
        
        storyManager.StopAllCoroutines();
    }
}