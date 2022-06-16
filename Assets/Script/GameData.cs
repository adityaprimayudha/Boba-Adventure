using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameData : MonoBehaviour
{
    public static GameData instance;

    public bool isSinglePlayer;

    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
         if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
