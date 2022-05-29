using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public static LevelSelection instance;
    public int level;
    public GameObject[] stars;
    public Image lockImage;
    private int star;
    public bool unlock;
    public Sprite img;
    private void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }
        else{
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        star = PlayerPrefs.GetInt("Level"+level);
    }

    // Update is called once per frame
    void Update()
    {
        UnlockedLevel();
    }
    void UnlockedLevel(){
        if(!unlock){
            lockImage.gameObject.SetActive(true);
            for(int i = 0;i<star;i++){
                stars[i].SetActive(false);
            }
        }
        else{
            lockImage.gameObject.SetActive(false);
            for(int i = 0;i < star;i++){
                stars[i].GetComponent<Image>().sprite = img;
                Debug.Log(""+star);
            }
        }
    }

    public void selectLevel(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
