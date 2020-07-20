using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOut : MonoBehaviour
{

    public Image fade;
    float fades = 1.0f;
    float time = 0;
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        fade = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        

        fade.color =  new Color (0,0,0,fades) * time;
    }
}
