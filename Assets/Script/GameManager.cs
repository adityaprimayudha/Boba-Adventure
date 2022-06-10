using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScriptableInteger condiment;
    // Start is called before the first frame update
    void Start()
    {
        condiment.doReset();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
