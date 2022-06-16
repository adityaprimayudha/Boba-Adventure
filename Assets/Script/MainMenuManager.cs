using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD

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
=======
public class MainMenuManager : MonoBehaviour
{
    [Header("Main Menu Panel List")]
    public GameObject mainMenu;
    public GameObject selectionMenu;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        selectionMenu.SetActive(false);
    }
    
    //Second Menu Script

    public void SinglePlayerButton()
    {
        GameData.instance.isSinglePlayer = true;
        mainMenu.SetActive(false);
        selectionMenu.SetActive(true);

>>>>>>> 6909a973b3d7dc94c896074dc83ce1e4296600fb
    }

    public void MultiPlayerButton()
    {
<<<<<<< HEAD
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
=======
        GameData.instance.isSinglePlayer = false;
        mainMenu.SetActive(false);
        selectionMenu.SetActive(true);
    }

    public void SettingBackButton()
    {
        mainMenu.SetActive(true);
        selectionMenu.SetActive(false);
    }
    
    
>>>>>>> 6909a973b3d7dc94c896074dc83ce1e4296600fb
}
