using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="IntemData", menuName = "Custom/Inventory")]
public class Items : ScriptableObject
{
    public string name;
    public Sprite icon;
    public string description = "";
    public GameObject prefab;

}
