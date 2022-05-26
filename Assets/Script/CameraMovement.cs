using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float distanceAhead;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    [SerializeField] float rightLimit;
    [SerializeField] float leftLimit;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        lookAhead = Mathf.Lerp(lookAhead, (distanceAhead*player.localScale.x), Time.deltaTime*cameraSpeed);
        transform.position = new Vector3(player.position.x + lookAhead,player.position.y, transform.position.z);
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,leftLimit,rightLimit),transform.position.y,transform.position.z);
    }
}
