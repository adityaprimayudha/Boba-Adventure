using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currhealth { get; private set; }

    void Awake()
    {
        currhealth = startingHealth;
        Debug.Log(""+currhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            TakeDamage(1);
        }
    }

    public void TakeDamage(float damage){
        currhealth = Mathf.Clamp(currhealth - damage, 0, startingHealth);
        Debug.Log(""+currhealth);

        if(currhealth>0){

        }
        else{
            GetComponent<PlayerMovement>().enabled = false;
            gameObject.SetActive(false);
        }
    }

    public void AddHealth(float value){
        currhealth = Mathf.Clamp(currhealth + value,0,startingHealth);
    }
}
