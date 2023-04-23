using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerZone : MonoBehaviour
{
    public GameObject positionPoint;
    public GameObject camera;
    public Transform cameraPosition;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = positionPoint.transform.position;
            camera.transform.position = cameraPosition.position;
        }
    }
}
