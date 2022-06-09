using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public enum Direction{
        X_POSITIVE,Y_POSITIVE,X_NEGATIVE,Y_NEGATIVE
    }

public class DoorMechanism : MonoBehaviour
{
    public Direction direction;
    private float x,y;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor(){
        if(direction == Direction.X_NEGATIVE){
            target = new Vector3(x-3f,transform.position.y,transform.position.z);
        }
        else if(direction == Direction.Y_NEGATIVE){
            target = new Vector3(transform.position.x,y-3f,transform.position.z);
        }
        else if(direction == Direction.X_POSITIVE){
            target = new Vector3(x+3f,transform.position.y,transform.position.z);
        }
        else if(direction == Direction.Y_POSITIVE){
            target = new Vector3(transform.position.x,y+3f,transform.position.z);
        }
        StartCoroutine(LerpDoor());
    }
    public void ExitDoor(){
        if(direction == Direction.X_NEGATIVE){
            target = new Vector3(x,transform.position.y,transform.position.z);
        }
        else if(direction == Direction.Y_NEGATIVE){
            target = new Vector3(transform.position.x,y,transform.position.z);
        }
        else if(direction == Direction.X_POSITIVE){
            target = new Vector3(x,transform.position.y,transform.position.z);
        }
        else if(direction == Direction.Y_POSITIVE){
            target = new Vector3(transform.position.x,y,transform.position.z);
        }
        StartCoroutine(LerpDoor());
    }
    private IEnumerator LerpDoor(){
        float lerpduration = 3f;
        float timeElapsed = 0;
        while(timeElapsed < lerpduration){
            timeElapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, target, timeElapsed/lerpduration);
            yield return null;
        }
    }
}
