using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    [SerializeField] Transform[] spwanPoints;
    [SerializeField] GameObject[] spwanItems;
    public float timer;
    public float startTime; 
    public float restTimer;

    void Start()
    {
        timer = startTime;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = restTimer;
            int randomitems = Random.Range(0, spwanItems.Length);
            int spwanposition = Random.Range(0, spwanPoints.Length);
            Instantiate(spwanItems[randomitems], spwanPoints[spwanposition].position, transform.rotation);
        }
        
    }
}
