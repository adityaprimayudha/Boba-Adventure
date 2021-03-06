using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public ScriptableInteger curlevel;
    public GameObject pausePanel;
    public void nextScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void nextLevel(int lvl){
        curlevel.value = lvl;
    }
    public void resume(){
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}
