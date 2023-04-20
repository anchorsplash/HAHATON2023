using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DescriptionScript : MonoBehaviour
{
    public GameObject manager;
    public GameObject plane;
    public DescriptionManager descriptionManager;

    private void Start()
    {
        descriptionManager = manager.GetComponent<DescriptionManager>();
    }
}
