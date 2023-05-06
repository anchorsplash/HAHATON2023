using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Action<Items> onItemAdd;
    //public Items item;
    [SerializeField] int inventoryCount = 5;
    public InventoryWindow window;
    public List<Items> currentItems = new List<Items>();
    public CanPickUp canPickUp;
    SphereCollider trigger;
    public QuestManager manager;

    public bool curcorOnObject;

    public bool bookCaracal1 = false;
    public bool bookshacal1 = false;
    public bool bookshacal2 = false;

    public LayerMask ItemTag; //Слой для предмета
    private Ray _ray; // Луч
    private RaycastHit _hit; // Место столкновения луча
    [SerializeField] private Camera _fpcCamera; // Камера
    [SerializeField] private float _maxDistanceRay; // Макс.дальность луча


    private void Start()
    {
        trigger = GetComponent<SphereCollider>();
    }
    private void FixedUpdate()
    {
        Ray(); // Активация луча
        Collider[] colliders = Physics.OverlapSphere(transform.position, trigger.radius);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].GetComponent<CanPickUp>())
            {
                canPickUp = colliders[i].GetComponent<CanPickUp>();
                //curcorOnObject = canPickUp.cursorOnObject;
            }
        }
    }

    private void Ray() // функция луча
    {
        _ray = _fpcCamera.ScreenPointToRay(Input.mousePosition);
    }

    public void AddItem(Items item, bool isQuestItem = false)
    {
        if (item.name == "diary")
        {
            canPickUp.pickUp = true;
            if (canPickUp.gameObject.name == "bookCaracal1")
            {
                bookCaracal1 = true;
                manager.Plashka("������ �� ��������� ������� ���� �����!");
            }
                
            else if (canPickUp.gameObject.name == "bookshacal1")
            {
                bookshacal1 = true;
                manager.TreasureQuestDone();
                manager.Plashka("������ �� ��������� ������ ���� �����!");
            }
            else if (canPickUp.gameObject.name == "bookshacal2")
            {
                bookshacal2 = true;
                manager.CartQuestDone();
                manager.Plashka("������ �� ��������� ������ ���� �����!");
            }
                
            return;
        }



        if(Physics.Raycast(_ray, out _hit,_maxDistanceRay, ItemTag)) //Если луч столкнулся с коллайдером со слоем ItemTag :
        {
            if ((currentItems.Count <= inventoryCount && canPickUp.inTrigger ) || isQuestItem) //&& curcorOnObject
            {
                currentItems.Add(item);
                canPickUp.pickUp = true;
                onItemAdd?.Invoke(item);
                window.Redraw();
            }
        }

    }

    public void DelItem(int index)
    {
        Vector3 pos = new Vector3(transform.position.x + 2, transform.position.y + 2, transform.position.z + 2);
        Instantiate(currentItems[index].prefab, pos, Quaternion.identity);
        currentItems.RemoveAt(index);
        window.Redraw();
    }
    public void DelItemQuest(Items item)
    {
        for (int i = 0; i < currentItems.Count; i++)
        {
            if (currentItems[i] == item)
                currentItems.RemoveAt(i);
        }
        window.Redraw();
    }
}
