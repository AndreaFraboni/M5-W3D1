using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private ItemSO _item;

    private string _tagPlayer = "Player";


    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(_tagPlayer)) return;


        PlayerInventory playerInv = other.gameObject.GetComponent<PlayerInventory>();

        if (playerInv != null)
        {
            playerInv.AddItem(_item);
            Debug.Log(other.gameObject.name + "ha recuperato :" + _item.Name);
        }



        Destroy(gameObject);
    }


}
