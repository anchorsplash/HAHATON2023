using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Action<Items> onItemAdd;
    public Items item;
    [SerializeField] int inventoryCount = 5;
    public InventoryWindow window;
    public List<Items> currentItems = new List<Items>();
    private void Start()
    {
        //AddItem(item);
    }

    void FixedUpdate()
    {
    }
    public void AddItem(Items item)
    {
        if (currentItems.Count <= inventoryCount)
        {
            currentItems.Add(item);
            onItemAdd?.Invoke(item);
        }
    }
}
