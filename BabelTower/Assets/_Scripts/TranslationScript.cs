using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScript : MonoBehaviour
{
    public QuestManager manager;
    public DialogTrigger dialog;

    private void Update()
    {
        if (manager.isWellUsed)
        {
            Debug.Log("LLLL");
            dialog.dialog.sentences[0] = "����������, ������ ������� �������� ������� ����, ��� ����� �����";
        }
            
        if (manager.isFishUsed)
        {
            dialog.dialog.sentences[1] = "� ������ ����� ������� ����";
        }
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
