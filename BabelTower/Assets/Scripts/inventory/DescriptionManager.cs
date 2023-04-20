using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DescriptionManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject plane;
    private void Start()
    {
        plane.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        plane.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        plane.SetActive(false);
    }
}
