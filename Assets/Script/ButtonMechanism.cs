using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMechanism : MonoBehaviour
{
    public DoorMechanism doorMechanism;
    public bool isExitDoor;
    // private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col){
        // anim.SetBool("Pressed",true);
        doorMechanism.OpenDoor();
    }
    private void OnCollisionExit2D(Collision2D col){
        // anim.SetBool("Pressed",false);
        if(isExitDoor){
            doorMechanism.ExitDoor();
        }
        else{
            
        }
    }
}