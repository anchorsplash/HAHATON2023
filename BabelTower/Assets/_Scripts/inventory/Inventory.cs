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
    public QuestManager manager;

    public bool curcorOnObject;

    public bool bookCaracal1 = false;
    public bool bookshacal1 = false;
    public bool bookshacal2 = false;
    private void Start()
    {
        trigger = GetComponent<SphereCollider>();
    }
    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, trigger.radius);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].GetComponent<CanPickUp>())
            {
                canPickUp = colliders[i].GetComponent<CanPickUp>();
                //curcorOnObject = canPickUp.cursorOnObject;
            }
        }
    }
    public void AddItem(Items item, bool isQuestItem = false)
    {
        if (item.name == "diary")
        {
            canPickUp.pickUp = true;
            if (canPickUp.gameObject.name == "bookCaracal1")
            {
                bookCaracal1 = true;
                manager.Plashka("Теперь вы понимаете ящерецу чуть лучше!");
            }
                
            else if (canPickUp.gameObject.name == "bookshacal1")
            {
                bookshacal1 = true;
                manager.TreasureQuestDone();
                manager.Plashka("Теперь вы понимаете шакала чуть лучше!");
            }
            else if (canPickUp.gameObject.name == "bookshacal2")
            {
                bookshacal2 = true;
                manager.CartQuestDone();
                manager.Plashka("Теперь вы понимаете шакала чуть лучше!");
            }
                
            return;
        }
        if ((currentItems.Count <= inventoryCount && canPickUp.inTrigger) || isQuestItem) //&& curcorOnObject
        {
            currentItems.Add(item);
            canPickUp.pickUp = true;
            onItemAdd?.Invoke(item);
            window.Redraw();
        }
    }

    public void DelItem(int index)
    {
        Vector3 pos = new Vector3(transform.position.x + 2, transform.position.y + 2, transform.position.z + 2);
        Instantiate(currentItems[index].prefab, pos, Quaternion.identity);
        currentItems.RemoveAt(index);
        window.Redraw();
    }
    public void DelItemQuest(Items item)
    {
        for (int i = 0; i < currentItems.Count; i++)
        {
            if (currentItems[i] == item)
                currentItems.RemoveAt(i);
        }
        window.Redraw();
    }
}
