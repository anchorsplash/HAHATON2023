using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Inventory inventory;

    public bool isWellUsed = false;
    public Items handle;
    //public 
    
    public bool isFishUsed = false;
    public Items fish;

    public bool isFeatherUsed = false;
    public Items feather;

    public bool isDiaryUsed = false;
    public Items diary;

    public bool isCartInBurn = false;
    public Items stickOnFire;
    public GameObject firePrefab;
    public GameObject book;

    public bool isStickUsed = false;
    public Items stick;

    public bool isGiftUsed = false;
    public Items gift;

    public bool isBreadUsed = false;
    public Items bread;
    public GameObject kroshka;

    public bool isAxeUsed = false;
    public Items axe;
    public GameObject brokenTree;

    public bool step1 = false;
    public bool step2 = false;
    public bool step3 = false;

    private void Start()
    {
        isWellUsed = false;
    }
    private void Update()
    {
        if (isWellUsed)
        {
            GameObject handleCopy = Instantiate(handle.prefab);
            Vector3 vector = new Vector3(-152.99f, 3.19f, -12.71f);
            handle.prefab.transform.position = vector;
            Quaternion rotation = new Quaternion(0, -90, 180, 0);
            handle.prefab.transform.rotation = rotation;
            Vector3 scale = new Vector3(-12.2f, -44.28727f, -12.2f);
            handle.prefab.transform.localScale = scale;

            handleCopy.GetComponent<Rigidbody>().isKinematic = true;

            inventory.DelItemQuest(handle);
            Debug.Log("Ëîë");
            step1 = true;
            isWellUsed = false;
        }
        if (isFishUsed)
        {
            inventory.DelItemQuest(fish);
            step2 = true;
        }
        if (isFeatherUsed)
        {
            inventory.DelItemQuest(feather);
            step3 = true;
        }
        if (isDiaryUsed)

        {
            inventory.DelItemQuest(diary);
        }

        if (isStickUsed)
        {
            inventory.DelItemQuest(stick);
            inventory.AddItem(stickOnFire, true);
            isStickUsed = false;
        }

        if (isCartInBurn)
        {
            inventory.DelItemQuest(stickOnFire);
            firePrefab.SetActive(true);
            book.SetActive(true);
        }
        if (isGiftUsed)
        {
            inventory.DelItemQuest(gift);

        }
        if (isBreadUsed)
        {
            inventory.DelItemQuest(bread);
            kroshka.SetActive(true);
        }
        if (isAxeUsed)
        {
        }
    }
}
