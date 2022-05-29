using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Data",menuName ="ScriptableObjects/Enemy",order =1)]
public class Enemy : ScriptableObject
{
    public string name;
    public int vitality;
    public Color enemyColor;
}
