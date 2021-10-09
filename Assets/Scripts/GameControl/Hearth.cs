using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth : MonoBehaviour
{
    [SerializeField] GameObject pickEffect;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(pickEffect, transform.position, Quaternion.identity);
            GameControl.health += 1;
        }
        
    }
}
