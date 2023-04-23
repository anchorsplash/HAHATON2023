using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPickUp : MonoBehaviour
{
    public Collider colliderPickUp;
    public Items item;
    public Inventory inventory;
    public bool pickUp;
    //public bool cursorOnObject = false;

    public bool inTrigger;
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    private void Update()
    {
        if (pickUp)
        {
            Destroy(gameObject);
            pickUp = false;
            inTrigger = false;
            //cursorOnObject = false;
        }
    }
    //private void OnMouseExit()
    //{
    //    cursorOnObject = false;
    //}
    //private void OnMouseEnter()
    //{
    //    cursorOnObject = true;
    //}
}
