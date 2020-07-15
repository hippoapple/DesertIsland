using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManWalk : MonoBehaviour
{
    public GameObject canvas;

    void Start() 
    {
        canvas.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        // 시간 흐름에 따라 투명도가 점점 어두워 진다.
        // canvas.MeshRenderer.material.color = new Color32(255, 255, 255, 0);
        SceneManager.LoadScene("Level6"); // 마지막 End Menu level6 씬이 켜진다.
    }
}

