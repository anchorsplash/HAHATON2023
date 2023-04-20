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
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (targetInvetory.curcorOnObject)
            {
                targetInvetory.AddItem(targetInvetory.canPickUp.item);
            }
        }
    }
}
