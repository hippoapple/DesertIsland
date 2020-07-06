using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Fire : MonoBehaviour
{
    public GameObject gauge;
    public float progress = 0f;

    bool isTriggerEnter = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggerEnter == true)
        {
            progress += Time.deltaTime * 5;
            gauge.gameObject.GetComponentInChildren<Slider>().value = progress;
        }

        if (progress == 10)
        {

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Branch")
        {
            isTriggerEnter = true;
            gauge.gameObject.SetActive(true);
        }
           
    }

    private void OnCollisionExit(Collision collision)
    {
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Branch")
        {
            isTriggerEnter = true;
            print("Enter");
            gauge.gameObject.SetActive(true);

        }
    }


    private void OnTriggerExit(Collider other)
    {
        isTriggerEnter = false;
        gauge.gameObject.SetActive(false);
        progress = 0f;
        GetComponentInChildren<Slider>().value = 0f;


    }

}
