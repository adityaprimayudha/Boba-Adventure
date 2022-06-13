using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public ScriptableInteger scriptValue;
    public GameObject[] stars;
    public bool reset;
    private int nilai;
    public ScriptableInteger curlevel;
    // Start is called before the first frame update

    void Start()
    {
        nilai = curlevel.value;
        Debug.Log(""+nilai);
        if(reset){
            PlayerPrefs.DeleteAll();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            goal.SetActive(true);
            Time.timeScale = 0;
            for(int i = 0; i<scriptValue.value; i++){
                stars[i].SetActive(true);
            }
            if(PlayerPrefs.GetInt("Level"+nilai) < scriptValue.value){
                PlayerPrefs.SetInt("Level"+nilai, scriptValue.value);
            }
            PlayerPrefs.SetString("Clear"+nilai, "Cleared");
            SoundManager.instance.Goal();
            Debug.Log(""+PlayerPrefs.GetInt("Level"+nilai));
        }
    }
}
