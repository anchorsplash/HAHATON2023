using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DescriptionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject plane;
    public GameObject descriptionText;
    public Items item;

    public void OnPointerEnter(PointerEventData eventData)
    {
        descriptionText.gameObject.SetActive(true);
        descriptionText.GetComponent<TMP_Text>().text = item.description;
        plane.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        descriptionText.gameObject.SetActive(false);
        plane.SetActive(false);
    }
}
