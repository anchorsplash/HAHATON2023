using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="IntemData", menuName = "Inventory")]
public class Items : ScriptableObject
{
    public string name;
    public Sprite icon;
    public bool canUse;
}
