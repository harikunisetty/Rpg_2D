using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("AIHealth")]

    [SerializeField] float AIHealth;
    private float maximumAiHealth = 100f;
    [SerializeField] GameObject pickEffect;

    [SerializeField] UIManager aiUIManager;
    void Start()
    {
        AIHealth = maximumAiHealth;
    }
    public void AiDamage(float hitvalue)
    {
        if (AIHealth > 0f)
        {
            AIHealth -= hitvalue;
            aiUIManager.AiHealthUI(AIHealth);

            if (AIHealth <= 0f)
                EnemyDead();
        }
        else
        {
            EnemyDead();
            Instantiate(pickEffect, transform.position, Quaternion.identity);
        }
    }

    public void EnemyDead()
    {        
        Destroy(gameObject);
        GameManager.Instance.UpdateKills();
    }
}
