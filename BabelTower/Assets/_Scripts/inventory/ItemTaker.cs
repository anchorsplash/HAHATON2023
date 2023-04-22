using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaker : MonoBehaviour
{
    [SerializeField] List<Items> itemsToAdd;
    [SerializeField] Items itemToAdd;
    [SerializeField] Inventory targetInvetory;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (targetInvetory.curcorOnObject)
            {
                targetInvetory.AddItem(targetInvetory.canPickUp.item);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            targetInvetory.DelItem(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            targetInvetory.DelItem(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            targetInvetory.DelItem(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            targetInvetory.DelItem(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            targetInvetory.DelItem(4);
        }
    }
}
