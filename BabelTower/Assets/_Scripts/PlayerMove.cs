using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    Camera cam;
    
    RaycastHit hit;
    Ray ray;
    Vector3 newDirection;
    private Animator anim;

    
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {         
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit,500, whatCanBeClickedOn))
            {

                newDirection = Vector3.RotateTowards(transform.forward, new Vector3(hit.point.x - transform.position.x,0f,hit.point.z - transform.position.z),0.15f,10);
                transform.rotation = Quaternion.LookRotation(newDirection);

                transform.position = Vector3.MoveTowards(transform.position, hit.point,Time.fixedDeltaTime*5);
                anim.SetBool("isRunning", true);
   
            }
        }
        else
        {
            anim.SetBool("isRunning", false);

        }   
    
    }

}
