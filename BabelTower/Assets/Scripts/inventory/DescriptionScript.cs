using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionScript : MonoBehaviour
{
    public GameObject plane;
    private void OnMouseEnter()
    {
        Debug.LogError("�����!");
        Instantiate(plane, Input.mousePosition, Quaternion.identity);
    }
}
