using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScriptableInteger condiment;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        condiment.doReset();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            SoundManager.instance.ClickButton();
        }
    }
}
