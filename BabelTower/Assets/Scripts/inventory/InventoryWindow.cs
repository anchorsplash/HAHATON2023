using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemsPanel;
    private void Start()
    {
        Redraw();
    }
    public void Redraw()
    {
        for (int i = 0; i < targetInventory.currentItems.Count; i++)
        {
            var item = targetInventory.currentItems[i];
            var icon = new GameObject(name: "Icon");
            icon.AddComponent<Image>().sprite = item.icon;
            icon.transform.SetParent(itemsPanel.transform);
        }
     }
    private void Update()
    {
        
    }

}
