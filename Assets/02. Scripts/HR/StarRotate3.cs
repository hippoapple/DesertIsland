using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotate3 : MonoBehaviour
{
    
    public float rotateSpeed = 360.0f;

    public GameObject star;
    public Transform centerStar;

    // Start is called before the first frame update
    void Start()
    {
        Hashtable ht = new Hashtable();
        ht.Add("time", 10.0f);
        ht.Add("path", iTweenPath.GetPath("StarPath3"));
        ht.Add("easetype", iTween.EaseType.linear); //easeOutBounce통통튐
        // ht.Add("looktarget",centerStar.position);
        //ht.Add("looktime",0.2f);
        // ht.Add("orienttopath", true); //길따라 보는것

        iTween.MoveTo(this.gameObject, ht);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0) * 180 * Time.deltaTime);
    }
    
}
