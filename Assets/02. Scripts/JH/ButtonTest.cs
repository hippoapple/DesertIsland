using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonTest : MonoBehaviour
{
    public void SceneChange()
    {
        Debug.Log("BUTTON CLICKED");
        SceneManager.LoadScene("ViveSetting_JH");
    }
}