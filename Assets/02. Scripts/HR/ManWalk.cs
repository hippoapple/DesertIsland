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
    public float passedTime = 8.0f;
    public float startTime = 3.0f;
    private float currentTime = 0.0f;

    private Animator animator;

    public float Get0assedTime()
    {
        return passedTime;
    }

    void Start()
    {
        //Canvas.enabled(true);
        //canvas.transform.Find("Image").gameObject.GetComponent<Color>();
        //canvas.GetComponent<Color>();
        //color.a = 0;

        //5초후 FadeOut애니매이션이 작동되라.
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > startTime)
        {
            animator.SetBool("isWalking",true);

        } 

        if (currentTime > passedTime)
            {  
                SceneManager.LoadScene("09. End Menu");
                currentTime = 0;
             //canvas.GetComponent<Color>();
             //color.a = 255;
            }

        // 하위 Image 의 0 0 0 0 에서 -> 0 0 0 255 로   ===>>>>>이거 애니매이션으로 처리했음
        // 10초후 투명도가 점점 어두워 진다.
        // canvas.MeshRenderer.material.color = new Color32(0, 0, 0, 0);
        // 마지막 End Menu level6 씬이 켜진다.
    }
        IEnumerator FadeOut()
        {
        yield return new WaitForSeconds(5);
        }

}

