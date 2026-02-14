using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<ItemSO> _inventory;
    [SerializeField] LifeController _lifeController;

    private void Awake()
    {
        _lifeController = GetComponent<LifeController>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {

        }
        if (Input.GetKey(KeyCode.Alpha3))
        {

        }
        if (Input.GetKey(KeyCode.Alpha4))
        {

        }
    }


    public void TryToUse(int itemIndex, GameObject target)
    {
        if (itemIndex < 0 || itemIndex >= _inventory.Count) return;
        if (_inventory[itemIndex] == null) return;

        _inventory[itemIndex].Use(target);

    }

    public void AddItem(ItemSO item)
    {
        _inventory.Add(item);
    }


    //public UseInventory(int numberItemList)
    //{



    //    foreach (ItemSO item in _inventory)
    //    {

    //    }

    
    //}



}
