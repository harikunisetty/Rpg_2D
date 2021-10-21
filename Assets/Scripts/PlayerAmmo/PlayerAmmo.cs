using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour
{
    [SerializeField] float lifetime = 3f;

    private void OnEnable()
    {
        Invoke("Die", lifetime);
    }

    void Die()
    {
        CancelInvoke();
        gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {            
            gameObject.SetActive(false);
            GameManager.Instance.UpdateKills();

            Debug.Log("Touch Enemy");
        }
    }
}
