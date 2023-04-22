using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemsPanel;

    [SerializeField] List<GameObject> iconsPrefabs;
    public List<GameObject> drawingList = new List<GameObject>();

    private void Start()
    {
        Redraw();
    }
    public void Redraw(bool isDelited = false, int index = 0)
    {
        ClearWindow();
        for (int i = 0; i < targetInventory.currentItems.Count; i++)
        {
            var item = targetInventory.currentItems[i];
            var icon = new GameObject(name: "Icon");
            icon.AddComponent<Image>().sprite = item.icon;

            icon.AddComponent<DescriptionScript>();
            GameObject canvas = GameObject.Find("Canvas");
            icon.GetComponent<DescriptionScript>().plane = canvas.transform.Find("DescriptionPanel").gameObject;
            GameObject text = canvas.transform.Find("DescriptionText").gameObject;
            icon.GetComponent<DescriptionScript>().descriptionText = text;
            icon.GetComponent<DescriptionScript>().item = item;

            icon.transform.SetParent(itemsPanel.transform);
            drawingList.Add(icon);
        }
    }
    void ClearWindow()
    {
        for (int i = 0; i < drawingList.Count; i++)
        {
            //drawingList[i] = drawingIcons[i];
            Destroy(drawingList[i]);
        }
        drawingList.Clear();
    }
}
