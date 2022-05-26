using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeIn : MonoBehaviour
{
    [Header("Main Settings")]
    public Image TargetImage;
    public float FadeSpeed;

    void Awake()
    {
        TargetImage.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }

    void StartFadeIn()
    {
        TargetImage.color = Color.Lerp(TargetImage.color, Color.clear, FadeSpeed * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartFadeIn();
    }
}