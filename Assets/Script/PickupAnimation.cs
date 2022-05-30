using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAnimation : MonoBehaviour
{
    public float y;
    private float localy;
    // Start is called before the first frame update
    void Start()
    {
        localy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, localy+Mathf.Sin(Time.time)*y, transform.position.z);
    }
}
