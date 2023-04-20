using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemsPanel;

    [SerializeField] List<GameObject> iconsPrefabs;
    readonly List<GameObject> drawingIcons = new List<GameObject>();
    private void Start()
    {
        Redraw();
        targetInventory.onItemAdd += OnItemAdd;
    }
    void OnItemAdd(Items obj) => Redraw();
    public void Redraw()
    {
        ClearWindow();
        for (int i = 0; i < targetInventory.currentItems.Count; i++)
        {
            var item = targetInventory.currentItems[i];
            var icon = new GameObject(name: "Icon");
            icon.AddComponent<Image>().sprite = item.icon;
            icon.AddComponent<DescriptionScript>();
            icon.GetComponent<DescriptionScript>().plane = icon.GetComponent<DescriptionScript>().descriptionManager.plane;
            icon.transform.SetParent(itemsPanel.transform);
            drawingIcons.Add(icon);
        }
     }
    void ClearWindow()
    {
        for (int i = 0; i < drawingIcons.Count; i++)
        {
            Destroy(drawingIcons[i]);
        }
        drawingIcons.Clear();
    }

}
