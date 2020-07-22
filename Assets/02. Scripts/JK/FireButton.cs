using UnityEngine;
using System.Collections;
 
public class CsGameManager : MonoBehaviour {
 
    public GameObject FireVideo;
    // Use this for initialization
    void Start () {
     
    }
     
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            FireVideo.SetActive(false);
        }
        if(Input.GetMouseButtonDown(1))
        {
            //오른족 버튼
            FireVideo.SetActive(true);
        }
    }
}

