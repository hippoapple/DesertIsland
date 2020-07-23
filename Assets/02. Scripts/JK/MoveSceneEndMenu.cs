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
   }
}
   
