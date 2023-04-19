using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Action<Items> onItemAdd;
    //public Items item;
    [SerializeField] int inventoryCount = 5;
    public InventoryWindow window;
    public List<Items> currentItems = new List<Items>();
    public CanPickUp canPickUp;
    SphereCollider trigger;

    bool curcorOnObject;

    private void Start()
    {
        trigger = GetComponent<SphereCollider>();
    }
    private void OnTriggerStay(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, trigger.radius);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].GetComponent<CanPickUp>())
            {
                canPickUp = colliders[i].GetComponent<CanPickUp>();
                if (canPickUp.cursorOnObject == true)
                {
                    curcorOnObject = true;
                }
            }
        }
    }
    public void AddItem(Items item)
    {
        if (currentItems.Count <= inventoryCount && canPickUp.inTrigger && curcorOnObject) 
        {
            canPickUp.pickUp = true;
            currentItems.Add(item);
            onItemAdd?.Invoke(item);
        }
    }
}
