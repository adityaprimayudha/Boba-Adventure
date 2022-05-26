using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public string sceneName;
    public float delay;
    public bool click;
    public Text text;
    public Animator animate;
    // Start is called before the first frame update
    void Start()
    {
        if(click){
            Invoke("clickNext",delay);
        }
        else{
            Invoke("nextScene",delay);
        }
    }

    // Update is called once per frame
    void Update()
    {
            if(!click){
                if(Input.GetKey(KeyCode.Mouse0)){
                nextScene();
            }
        }
    }
    public void nextScene(){
        SceneManager.LoadScene(sceneName);
    }
    public void clickNext(){
        text.enabled = true;
        animate.enabled = true;
        text.text = "Click here to start";
        click = false;
    }
}
