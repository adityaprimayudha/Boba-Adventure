using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanism : MonoBehaviour
{
    private float x;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor(){
        target = new Vector3(x-3f,transform.position.y,transform.position.z);
        StartCoroutine(LerpDoor());
    }
    public void ExitDoor(){
        target = new Vector3(x,transform.position.y,transform.position.z);
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
