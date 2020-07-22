using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCam : MonoBehaviour
{
    public GameObject hc;
    public Transform centerTr;

    // Start is called before the first frame update
    void Start()
    {
        Hashtable ht = new Hashtable();
        ht.Add("time", 20.0f);
        ht.Add("path", iTweenPath.GetPath("Fly"));
        ht.Add("easetype", iTween.EaseType.linear); //easeOutBounce통통튐
        ht.Add("orienttopath", true);
        // ht.Add("lookpath", "looktarget");
        // ht.Add("orienttotarget", "lookpath");
        // ht.Add("looktarget",centerTr.position);
        // ht.Add("looktime",0.2f);
        // // ht.Add("orienttopath", true); //길따라 보는것

        iTween.MoveTo(hc, ht);
    }
}
