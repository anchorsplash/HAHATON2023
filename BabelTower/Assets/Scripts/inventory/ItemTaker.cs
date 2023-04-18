using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaker : MonoBehaviour
{
    [SerializeField] Items itemToAdd;
    [SerializeField] Inventory targetInvetory;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            targetInvetory.AddItem(itemToAdd);
        }
    }
}
