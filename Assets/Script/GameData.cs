using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{

    [Header("Panels")]
    public GameObject PausePanel;
    public GameObject GameOverPanel;

    [Header("Game Over UI")]
    public GameObject player1WinUI;
    public GameObject player2WinUI;
    public GameObject youWin;
    public GameObject youLose;

    void Start()
    {
        PausePanel.SetActive(false);
        GameOverPanel.SetActive(false);

        youWin.SetActive(false);
        youLose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        PausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        PausePanel.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartEasy()
    {
        SceneManager.LoadScene("LevelEasy");
    }

    public void RestartMedium()
    {
        SceneManager.LoadScene("LevelMedium");
    }

    public void RestartHard()
    {
        SceneManager.LoadScene("LevelHard");
    }
}
