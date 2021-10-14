using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwan : MonoBehaviour
{
   /* [SerializeField] GameObject enemy;
    [SerializeField] GameObject newEnemy;
    [SerializeField] SpriteRenderer rend;
    private int rendomSpawnZone;
    private float xInput, yInput;
    private Vector3 spawnPosition;

    private void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 2f);
    }
    private void SpawnNewEnemy()
    {
        rendomSpawnZone = Random.Range(0, 4);
        switch (rendomSpawnZone)
        {
            case 0:
                xInput = Random.Range(-11f, -10f);
                yInput= Random.Range(-8f, -8f);
                break;
            case 1:
                xInput = Random.Range(-10f, 10f);
                yInput = Random.Range(-7f, -8f);
                break;
            case 2:
                xInput = Random.Range(10f, 11f);
                yInput = Random.Range(-8f, 8f);
                break;
            case 3:
                xInput = Random.Range(-10f, 10f);
                yInput = Random.Range(7f, 8f);
                break;
        }
        spawnPosition = new Vector3(xInput, yInput, 0f);
        newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity);
        rend = newEnemy.GetComponent<SpriteRenderer>();
        rend.color = new Color(Random.Range(0, 2), Random.Range(0, 2), 1f);
    }*/
}
