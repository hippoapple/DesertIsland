using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Valve.VR;
//SteamVR_LaserPointer의 네임스페이스
using Valve.VR.Extras;

public class ChangeScene : MonoBehaviour 
    {

        public void SceneChange()
        {
            
            SceneManager.LoadScene(1);
            
        }
        
    }

