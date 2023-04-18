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

/*    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }*/

    public void OnTriggerEnter(Collider other)
    {
        StartDialogPanel.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        StartDialogPanel.SetActive(false);
        dm.EndDialog();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            ChangeSprite.GetComponent<Image>().sprite = Img;
        }
    }
}
