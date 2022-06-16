using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    }

    public void MultiPlayerButton()
    {
        GameData.instance.isSinglePlayer = false;
        mainMenu.SetActive(false);
        selectionMenu.SetActive(true);
    }

    public void SettingBackButton()
    {
        mainMenu.SetActive(true);
        selectionMenu.SetActive(false);
    }
    
    
}
