using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Sprite Img;
    public Dialog dialog;
    public GameObject StartDialogPanel, ChangeSprite;
    public DialogManager dm;

    bool cursorOnObject;


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
        cursorOnObject = true;
    }
    private void OnMouseExit()
    {
        cursorOnObject = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && cursorOnObject)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            ChangeSprite.GetComponent<Image>().sprite = Img;
        }
    }
}
