using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Main Menu Panel List")]
    public GameObject MainPanel;
    public GameObject LevelSelectionPanel;

    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        LevelSelectionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SinglePlayerButton()
    {
        LevelSelectionPanel.SetActive(true);
    }

    public void MultiPlayerButton()
    {
        LevelSelectionPanel.SetActive(true);
    }

    public void BackButton()
    {
        LevelSelectionPanel.SetActive(false);
    }

    public void StartEasy()
    {
        SceneManager.LoadScene("LevelEasy");
    }

    public void StartMedium()
    {
        SceneManager.LoadScene("LevelMedium");
    }

    public void StartHard()
    {
        SceneManager.LoadScene("LevelHard");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
