using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wellQuest : MonoBehaviour
{
    public QuestManager manager;
    public Inventory inventory;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Debug.Log("Е нажата");
                if (FindItem(inventory.currentItems, manager.handle) == true)
                {
                    //Debug.Log("Я люблю пицуцу");
                    manager.isWellUsed = true;
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
