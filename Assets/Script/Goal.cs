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
    // Start is called before the first frame update

    void Start()
    {
        if(reset){
            PlayerPrefs.DeleteKey("Level"+1);
        }
        nilai = LevelSelection.instance.level;
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
            PlayerPrefs.SetInt("Level"+nilai, scriptValue.value);
            Debug.Log(""+scriptValue.value);
        }
    }
}
