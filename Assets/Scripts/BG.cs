using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BG : MonoBehaviour
{
    //필요속성 재질 스크롤스피드
    Material mat;
    public float scrollspeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        //0. Mesh Renderer\ 컴퍼넌트 찾아오기.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        //1. Material이 있어야 한다.
        mat = mr.material;

    }

    // Update is called once per frame
    void Update()
    {
        //배경이 계속 스크롤 되도록 하고 싶다.
        //-> offset 속성의 y값을 점차적으로 증가시킬 것임
        //2. offset을 찾아서
        //3. y값을 키워준다.
        //P=P0+v*t
        mat.mainTextureOffset += Vector2.up * scrollspeed * Time.deltaTime;

    }
}
