using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStickQuest : MonoBehaviour
{
    public QuestManager manager;
    public Inventory inventory;
    public bool cursorOnObject;
    private void OnMouseEnter()
    {
        cursorOnObject = true;
    }
    private void OnMouseExit()
    {
        cursorOnObject = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                //Debug.Log("Е нажата");
                if (FindItem(inventory.currentItems, manager.stick) == true)
                {
                    //Debug.Log("Я люблю пицуцу");
                    manager.isStickUsed = true;
                }
            }
        }
    }

    public bool FindItem(List<Items> list, Items item)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == item)
                return true;
        }
        return false;
    }
    public int FindItemInt(List<Items> list, Items item)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == item)
                return i;
        }
        return 0;
    }
}
