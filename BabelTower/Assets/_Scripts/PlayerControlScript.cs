using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public bool active = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (active)
            {
                gameObject.SetActive(false);
                active = false;
            }
            else 
            {
                gameObject.SetActive(true);
                active = true;
            }
        }
    }
}
