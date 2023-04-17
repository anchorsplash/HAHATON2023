using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Items item;
    [SerializeField] int inventoryCount = 5;
    public InventoryWindow window;
    public List<Items> currentItems = new List<Items>();

    public int currentInventoryCount = 0;

    private void Start()
    {
        //AddItem(item);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("AddItem", 0.1f);

            window.Redraw();
        }
    }
    void AddItem()
    {
        if (currentInventoryCount <= inventoryCount)
        {
            Debug.Log("Вошел");
            currentItems.Add(item);
            currentInventoryCount++;
        }
    }
}
