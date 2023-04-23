using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslitionScriptShakal : MonoBehaviour
{
    public QuestManager manager;
    public DialogTrigger dialog;

    bool b = false;
    private void Update()
    {
        if (manager.isFeatherUsed)
        {
            dialog.dialog.sentences[2] = "� ����� ���, � ������ ����";
        }
        if (manager.isCartInBurn)
            dialog.dialog.sentences[0] = "���������, ��� ��� ������� �� ���� ��������..";

        if (manager.isGiftUsed)
            dialog.dialog.sentences[1] = "� ����� ���, � ������ ����";
    }
}
