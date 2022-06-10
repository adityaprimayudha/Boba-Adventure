using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Integer", menuName = "Scriptable Variable/Integer")]
public class ScriptableInteger : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool ResetOnEnable;

    private void OnEnable(){
        if(ResetOnEnable){
            value = defaultValue;
        }
    }
    public void doReset(){
        value = defaultValue;
    }
}
