using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScriptKarakal : MonoBehaviour
{
    public DialogTrigger dialog;

    private bool isTreasureDone = false;
    private bool isCartDone = false;
    public void HandleQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("�����. ��� ��� ������ ������� ������ ����. �� ������ ������."));
        dialog.dialog.sent.Add(new Dialog.Sentences("�� ��, ��� � ���� � ������ ���� �� ��������...�", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("���� ����?"));
        dialog.dialog.sent.Add(new Dialog.Sentences("����-����... ���, ������. ����� ������� �  �����. � ������ �������� ����.", true));
    }
    public void FishQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("����, ��� ����, ��� ��� ������ ������. "));
        dialog.dialog.sent.Add(new Dialog.Sentences("��. ���������. ���. �����. �� �� ��� ��������� ����, �����?", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("��, ��� ��� ������ ������, �������� ������ ��� �����... "));
        dialog.dialog.sent.Add(new Dialog.Sentences("� ���� ���������, ������-������ �� ����� ���-��."));
        dialog.dialog.sent.Add(new Dialog.Sentences("� �� ��� ������� ���� ��������� �������� ����� �����, " +
            "�� ��� ����� ������ ����� ����. ���� ���� � � �� ������ ���-���."));

    }
    public void FeatherQuestDone()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("End");
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("����� ���� ����. �������? ������-�� �� ������� ������� �����?! " +
            "� ����������� ��������.", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("�������� �����, ��� ������ ������. ������ � ������� ���� ��������."));
        dialog.dialog.sent.Add(new Dialog.Sentences("�������� ��������� ���� � �����������, ������� ��������� ������� � �������� �������� ��������������. " +
            "�������, ��� �� � ��� ��������."));
        dialog.dialog.sent.Add(new Dialog.Sentences("���. ����� ���� ����� ���. �� �� ��� ������� ��� �������? " +
            "����� �� ��� ���� � ����� ����?! � ���� ������� �� ����.", true)); ;
        dialog.dialog.sent.Add(new Dialog.Sentences("� ������ ��� ������, ��� ���� �� �� ���������. " +
            "�� ��� �� �� ����, �� � ������ ���� ��������� �����, ����-��������! ������."));
    }

    public void TreasureQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("��� ����� ����. ��-�-�� �����!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("�������, �� ����������.", true));
        isTreasureDone = true;
    }
    public void CartQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("���� ����! ������ ���� ����� ����!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("�������, �� ������ ������������ ���-��.", true));
        isCartDone = true;
    }
    public void GiftQuestProcess()
    {
        if (isCartDone && isTreasureDone)
        {
            dialog.dialog.Clear();
            dialog.dialog.sent.Add(new Dialog.Sentences("����� ����� ���� ������ ���. ������ ���� ������! " +
                "����� ������ �� ���-���! ��� �� ����..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("� ��� ����, ���������?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("�, ���� ��������! � ��� � ���� ������ ���� ��������, " +
                "�� � �������� ��� � ��� ������ ��� �����..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("����, � ��� ���� ���� �������� � ���� ����?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("����, �� ��� ������, �����."));
            dialog.dialog.sent.Add(new Dialog.Sentences("������� �������...", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("�� ��� �� ������� ���? ����� �������, ������� �������� ��� �������."));
            dialog.dialog.sent.Add(new Dialog.Sentences("������, � �����.", true));
        }        
    }
    public void GiftQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("�������, ��� ������ ��, ��� �� ������! � ����� ������� ����� �������. " +
            "� ������ � ����. ������ �� ������������� � ��������� ���� �����."));
    }
}
