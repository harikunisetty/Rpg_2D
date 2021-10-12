using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwan : MonoBehaviour
{
    [Header("SpwanEnemy")]
    [SerializeField] Transform[] spwanPoints;
    [SerializeField] GameObject[] spwanEnemy;
    public float timerCount;
    public float enemyStartTime;
    public float restTime;

    void Start()
    {
        timerCount = enemyStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerCount = -Time.deltaTime;
        if (timerCount <= 0)
        {
            timerCount = restTime;
            int randomitems = Random.Range(0, spwanEnemy.Length);
            int spwanposition = Random.Range(0, spwanPoints.Length);
            Instantiate(spwanEnemy[randomitems], spwanPoints[spwanposition].position, transform.rotation);
        }
    }
}
