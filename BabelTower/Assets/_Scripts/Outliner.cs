using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outliner : MonoBehaviour
{
    private Outline outline;
    public LayerMask ItemTag;

    [SerializeField] private Camera _fpcCamera;
    [SerializeField] private float _maxDistanceRay;
    private Ray _ray;
    private RaycastHit _hit;

    
    void Update()
    {
        Ray();
        OutLining();
    }

    private void Ray()
    {
        _ray = _fpcCamera.ScreenPointToRay(Input.mousePosition);
    }
    private void OutLining()
    {
        if(Physics.Raycast(_ray, out _hit,_maxDistanceRay,ItemTag))
        {
            outline = _hit.transform.GetComponent<Outline>();
            outline.GetComponent<Outline>().OutlineWidth = 6;
        }
        else
        {
            outline.GetComponent<Outline>().OutlineWidth = 0;
        }
    }

    
}
