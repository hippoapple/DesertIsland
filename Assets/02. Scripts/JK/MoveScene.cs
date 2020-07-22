using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         SceneManager.LoadScene("01. MainScene");

    //     }
    // }



    //    public void TutorialOn(bool true)
    //   {
    //         gameObject.GetComponent<"Tutorial">().enabled = false;
    //   }

    // public GameObject Tutorial;
    // // Use this for initialization
    // void Start () {
     
    // }
     
    // // Update is called once per frame
    // void Update () {
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         Tutorial.SetActive(false);
    //     }
    //     if(Input.GetMouseButtonDown(1))
    //     {
    //         //오른족 버튼
    //         Tutorial.SetActive(true);
    //     }
    // }

       public void GoToScene(string sceneName)
   {
        SceneManager.LoadScene(sceneName);
        //SceneManager.LoadScene()
   }
//    public void GoToScene2(string sceneName)
//    {
//         SceneManager.LoadScene("01. MainScene""ViveSetting_HR");
//         //SceneManager.LoadScene()
//    }

}
