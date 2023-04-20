using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DescriptionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject plane;

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("Description").SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject.Find("Description").SetActive(false);
    }
}
