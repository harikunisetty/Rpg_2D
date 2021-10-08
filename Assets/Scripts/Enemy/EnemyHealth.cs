using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("AIHealth")]

    [SerializeField] float AIHealth;
    private float maximumAiHealth = 100f;
    void Start()
    {
        AIHealth = maximumAiHealth;
    }
    public void AiDamage(float hitvalue)
    {
        if (AIHealth > 0f)
        {
            AIHealth -= hitvalue;
            UIManager.Instance.AiHealthUI(AIHealth);

            if (AIHealth <= 0f)
                EnemyDead();
        }
        else
        {
            EnemyDead();
        }
    }

    public void EnemyDead()
    {
        Destroy(gameObject);
    }
}
