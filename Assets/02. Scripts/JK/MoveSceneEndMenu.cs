using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneEndMenu : MonoBehaviour
{
    //    private void Update()
    //    {
    //         if (Input.GetMouseButtonDown(0))
    //         {
    //             SceneManager.LoadScene("ViveSetting_JK_2");
    //         }

    //    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        StoryManager1.clickCount = -1;
        FireFire.woodCount = 0;

        PotPosition.isBigpotEnter = false;
        PotPosition.isbigwateron = false;

        ReadyWaterStep1.isWaterOn = false;
        ReadyWaterStep1.IsSmallCup = false;
        ReadyWaterStep1.IsPotLid = false;

        StartFire.isFireOn = false;
        DrinkWater.isDrink = false;
        StoryManager1.clickCount = -1;
        GrabMgr.isFlag = false;
    }
}

