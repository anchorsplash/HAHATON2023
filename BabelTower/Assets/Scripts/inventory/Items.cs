using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="IntemData", menuName = "Custom/Inventory")]
public class Items : ScriptableObject
{
    public string name;
    public Sprite icon;
    public bool canUse = false;
    public bool canPickUp = false;
    public bool pickUp = false;
    public string description = "";

}
