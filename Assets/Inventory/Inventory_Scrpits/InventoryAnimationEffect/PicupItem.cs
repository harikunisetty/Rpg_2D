using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicupItem : MonoBehaviour
{
    [SerializeField] InventoryItem ItemData;
    [SerializeField] GameObject pickEffect;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (InventoryManager.Instance.items.Count < InventoryManager.Instance.Slots.Length)
            {
                Instantiate(pickEffect, transform.position, Quaternion.identity);
                gameObject.SetActive(false);
                InventoryManager.Instance.Additem(ItemData);
            }
            else
            {
                Debug.Log("You Cannot Pick Up Any Items Now ,your Bag Is Full!!!");
            }
           
        }
    }

}
