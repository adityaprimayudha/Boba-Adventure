using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void nextScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
