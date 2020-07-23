using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum GameState
    {
        menu,
        inGame,
        gameOver
    }

    public void ReStartGame()
    {
        //SetGameState(GameState.inGame);
        //AudioSource playButton2 = playAgainButton.GetComponent<AudioSource>();
        //playButton2.Play();
        //levelGenerator.instance.ReStageSetting();
        PlayerController.instance.ReStartGame();
        SceneManager.LoadScene("01. MainScene");
    }
}
