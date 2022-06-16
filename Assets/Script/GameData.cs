using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
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
=======

public class GameData : MonoBehaviour
{
    public static GameData instance;

    public bool isSinglePlayer;

    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
         if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
>>>>>>> 6909a973b3d7dc94c896074dc83ce1e4296600fb
    }

    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< HEAD

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
=======
>>>>>>> 6909a973b3d7dc94c896074dc83ce1e4296600fb
}
