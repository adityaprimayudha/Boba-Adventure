using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScriptableInteger condiment;
    public GameObject pausePanel;

    [Header("Player 2")]
    public GameObject Player2Prefab;
    private GameObject Player2Spawned;
    public float XPrefabP2;
    public float YPrefabP2;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
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
    public void SpawnPlayer()
    {
        if (Player2Spawned == null && !GameData.instance.isSinglePlayer)
        {
        Player2Spawned = Instantiate(Player2Prefab, Vector3.zero, Quaternion.identity);
        Player2Spawned.transform.position = new Vector3(XPrefabP2, YPrefabP2, 0);
        } 
        else {}
    }
}
