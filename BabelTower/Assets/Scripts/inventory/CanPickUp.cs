using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPickUp : MonoBehaviour
{
    public Collider colliderPickUp;
    public Items item;
    public Inventory inventory;
    private void OnTriggerEnter(Collider other)
    {
        item.canPickUp = true;
    }
    private void OnTriggerExit(Collider other)
    {
        item.canPickUp = false;
    }
    private void Update()
    {
        if (item.pickUp)
        {
            Destroy(this.gameObject);
            item.canPickUp = false;
            item.pickUp = false;
        }
    }

}
