using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public int level;
    public ScriptableInteger curlevel;    
    public GameObject[] stars;
    public Image lockImage;
    private int star;
    public bool unlock;
    public Sprite img;
    
    // Start is called before the first frame update
    void Start()
    {
        star = PlayerPrefs.GetInt("Level"+level);
        if(!unlock){
            if(PlayerPrefs.GetString("Clear"+(level-1)) == "Cleared"){
                unlock = true;
            }
        }
        Debug.Log("Level : "+level+"\nStar : "+star);
    }

    // Update is called once per frame
    void Update()
    {
        UnlockedLevel();
    }
    void UnlockedLevel(){
        if(!unlock){
            lockImage.gameObject.SetActive(true);
            this.GetComponent<Button>().interactable = false;
            for(int i = 0;i<star;i++){
                stars[i].SetActive(false);
            }
        }
        else{
            lockImage.gameObject.SetActive(false);
            for(int i = 0;i < star;i++){
                stars[i].GetComponent<Image>().sprite = img;
                //Debug.Log(""+star);
            }
        }
    }

    public void selectLevel(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void currentLevel(int value){
        curlevel.value = value;
    }
}
