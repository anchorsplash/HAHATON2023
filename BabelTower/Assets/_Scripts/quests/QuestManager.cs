using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Inventory inventory;
    public wellQuest wellQuest;
    public FishQuest fishQuest;

    public bool isWellUsed = false;
    public Items handle;
    
    public bool isFishUsed = false;
    public Items fish;

    public bool isFeatherUsed = false;
    public Items feather;

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
            Instantiate(handle.prefab);
            Vector3 vector = new Vector3(-263.66f, 1.96f, 83.13f);
            handle.prefab.transform.position = vector;
            Quaternion rotation = new Quaternion(90, 0, -90, 0);
            handle.prefab.transform.rotation = rotation;
            Vector3 scale = new Vector3(-12.2f, -44.28727f, -12.2f);
            handle.prefab.transform.localScale = scale;

            handle.prefab.GetComponent<Rigidbody>().isKinematic = true;

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
    }
}
