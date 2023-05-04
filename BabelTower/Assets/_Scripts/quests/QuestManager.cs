using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public Inventory inventory;
    public TranslationScriptKarakal trKaracal;
    public TranslationScriptKarakal trShakal;
    [Space]

    public GameObject plashka;
    public TextMeshProUGUI plashakText;

    [Space]
    public GameObject bookHandleQuest;
    public bool isWellUsed = false;
    public Items handle;
    
    [Space]

    public bool isFishUsed = false;
    public Items fish;

    [Space]

    public bool isFeatherUsed = false;
    public Items feather;

    [Space]

    public bool isDiaryUsed = false;
    public Items diary;

    [Space]

    public bool isCartInBurn = false;
    public Items stickOnFire;
    public GameObject firePrefab;
    public GameObject book;
    public GameObject shacals;
    public Transform shacalsPositions;

    [Space]

    public bool isStickUsed = false;
    public Items stick;

    [Space]

    public bool isGiftUsed = false;
    public Items gift;

    [Space]

    public bool isBreadUsed = false;
    public Items bread;
    public GameObject kroshka;
    public Animator pinguinAnimator;

    [Space]

    public bool isAxeUsed = false;
    public Items axe;
    public GameObject brokenTree;
    [Space]
    [Space]
    public bool bookCaracal1 = false;
    public bool bookshacal1 = false;
    public bool bookshacal2 = false;

    public bool isTreasureFind = false;

    private void Update()
    {
        if (isWellUsed)
        {
            HandleQuestDone();
            isWellUsed = false;
        }
        else if (isFishUsed)
        {
            FishQuestDone();
            isFishUsed = false;
        }
        else if (isFeatherUsed)
        {
            FeatherQuestDone();
            isFeatherUsed = false;
        }
        else if (isTreasureFind)
        {
            TreasureQuestDone();
            isTreasureFind = false;
        }
        else if (isCartInBurn)
        {
            CartQuestDone();
            isCartInBurn = false;
        }
        else if (isStickUsed)
        {
            StickQuestDone();
            isStickUsed = false;
        }
        else if (isGiftUsed)
        {
            GiftQuestDone();
            isGiftUsed = false;
        }
        else if (isBreadUsed)
        {
            BreadQuestDone();
            isBreadUsed = false;
        }
    }


    public void HandleQuestDone()
    {
        trKaracal.HandleQuestDone();

        isWellUsed = true;
        GameObject handleCopy = Instantiate(handle.prefab);
        Vector3 vector = new Vector3(-152.99f, 3.19f, -12.71f);
        handle.prefab.transform.position = vector;
        Quaternion rotation = new Quaternion(0, -90, 180, 0);
        handle.prefab.transform.rotation = rotation;
        Vector3 scale = new Vector3(-12.2f, -44.28727f, -12.2f);
        handle.prefab.transform.localScale = scale;

        handleCopy.GetComponent<Rigidbody>().isKinematic = true;

        inventory.DelItemQuest(handle);
        bookHandleQuest.SetActive(true);
    }
    public void FishQuestDone()
    {
        isFishUsed = true;
        inventory.DelItemQuest(fish);
        trKaracal.FishQuestDone();
        Plashka("Теперь вы понимаете ящерицу лучше!");
    }
    public void FeatherQuestDone()
    {
        isFeatherUsed = true;
        inventory.DelItemQuest(feather);
        trKaracal.FeatherQuestDone();
        Plashka("Теперь вы понимаете ящерицу лучше!");
    }
    public void TreasureQuestDone()
    {
        isTreasureFind = true;
        trShakal.TreasureQuestDone();
        trShakal.GiftQuestProcess();
    }

    public void CartQuestDone()
    {
        trShakal.CartQuestDone();
        isCartInBurn = true;
        inventory.DelItemQuest(stickOnFire);
        firePrefab.SetActive(true);
        book.SetActive(true);
        shacals.transform.position = shacalsPositions.position;
        trShakal.GiftQuestProcess();
    }
    public void StickQuestDone()
    {
        isStickUsed = true;
        inventory.DelItemQuest(stick);
        inventory.AddItem(stickOnFire, true);
        isStickUsed = false;
    }
    public void GiftQuestDone()
    {
        isGiftUsed = true;
        inventory.DelItemQuest(gift);
        Plashka("Вы отдали подарок шакалу!");
        trShakal.GiftQuestDone();
    }
    public void BreadQuestDone()
    {
        isBreadUsed = true;
        inventory.DelItemQuest(bread);
        kroshka.SetActive(true);
        pinguinAnimator.SetBool("Fall", true);
    }

    public void Plashka(string text)
    {
        plashakText.text = text;
        plashakText.gameObject.SetActive(true);
        plashka.SetActive(true);
        StartCoroutine(Waiting(3, plashka));
        StartCoroutine(Waiting(3, plashakText.gameObject));
    }

    IEnumerator Waiting(float delay, GameObject gObject)
    {
        yield return new WaitForSeconds(delay);
        gObject.SetActive(false);
    }
}
