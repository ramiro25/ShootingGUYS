using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject restartBtnn;
    public GameObject hero;
    private bool gameIsOver;

    private void Start() 
    {
        gameIsOver = false;
    }

    private void Update() 
    {
        if(hero == null && gameIsOver == false)
        {
            GameOver();
            gameIsOver = true;
        }
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        restartBtnn.SetActive(true);
    }

    public void RestartGame()
    {
        gameOverUI.SetActive(false);
        restartBtnn.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}