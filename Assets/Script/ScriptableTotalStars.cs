using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Integer", menuName = "Scriptable Variable/Total Stars")]

public class ScriptableTotalStars : ScriptableObject
{
    public List<int> total = new List<int>();
}
