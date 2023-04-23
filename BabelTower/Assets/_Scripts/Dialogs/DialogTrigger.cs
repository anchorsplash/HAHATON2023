using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Sprite Img;
    public Dialog dialog;
    public GameObject StartDialogPanel, awatar;
    public DialogManager dm;

    public bool cursorOnObject;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            StartDialogPanel.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartDialogPanel.SetActive(false);
            dm.EndDialog();
        }
    }
    private void OnMouseEnter()
    {
        if (GetComponent<BoxCollider>())
            cursorOnObject = true;
    }
    private void OnMouseExit()
    {
        if (GetComponent<BoxCollider>())
            cursorOnObject = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && cursorOnObject)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            awatar.GetComponent<Image>().sprite = Img;
        }
    }
}
