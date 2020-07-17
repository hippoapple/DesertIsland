using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManWalk : MonoBehaviour
{
    public GameObject manWalk;
    // public Canvas canvas;
    // public Color color;
    public float passedTime = 5.0f;
    private float currentTime = 0.0f;

    void Start()
    {
        //Canvas.enabled(true);
        //canvas.transform.Find("Image").gameObject.GetComponent<Color>();
        //canvas.GetComponent<Color>();
        //color.a = 0;
    }


    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > passedTime)
            {  
                SceneManager.LoadScene("09. End Menu");
                currentTime = 0;
             //canvas.GetComponent<Color>();
             //color.a = 255;
            }

        // 하위 Image 의 0 0 0 0 에서 -> 0 0 0 255 로
        // 10초후 투명도가 점점 어두워 진다.
        // canvas.MeshRenderer.material.color = new Color32(0, 0, 0, 0);
        // 마지막 End Menu level6 씬이 켜진다.
    }
}

