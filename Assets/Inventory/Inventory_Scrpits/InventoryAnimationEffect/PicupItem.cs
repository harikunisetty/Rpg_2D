using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PicupItem : MonoBehaviour
{
    [SerializeField] InventoryItem ItemData;
    [SerializeField] GameObject pickEffect;
    [SerializeField] float lifetime = 10f;

    private void OnEnable()
    {
        Invoke("Die", lifetime);
    }
    void Die()
    {
        CancelInvoke();
        gameObject.SetActive(false);
    }

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
