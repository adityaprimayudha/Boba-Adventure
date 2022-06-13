using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip clickbutton;
    public AudioClip getItem;
    public AudioClip goal;
    public AudioClip dead;
    private AudioSource audio;
    void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }
        else{
            instance = this;
        }
        audio = GetComponent<AudioSource>();
    }
    public void ClickButton(){
        audio.PlayOneShot(clickbutton);
    }
    public void GetItem(){
        audio.PlayOneShot(getItem);
    }
    public void Goal(){
        audio.PlayOneShot(goal);
    }
    public void Dead(){
        audio.PlayOneShot(dead);
    }
}
