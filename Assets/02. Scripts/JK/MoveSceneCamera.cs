using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneCamera : MonoBehaviour
{
    float timer;
    int waitingTime;
    bool inside;
    // Start is called before the first frame update
    void Start()
    {
          timer = 0.0f;
          waitingTime = 12;
          inside = false;
    }

    // Update is called once per frame
    void Update()
    {
          timer += Time.deltaTime;
   
         if(timer > waitingTime)
        {
            //Action
            SceneManager.LoadScene("ViveSetting_JK_2");
            timer = 0;
        }

    }
}
