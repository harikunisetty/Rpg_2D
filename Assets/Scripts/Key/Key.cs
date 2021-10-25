using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    public GameObject levelObject;
    public GameObject keyObject;
    public float timer;
    public float startTime;
    public float stopTimer;
    void Start()
    {
        timer = startTime;

        keyObject.gameObject.SetActive(false);
        levelObject.gameObject.SetActive(false);
    }

   
    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = stopTimer;
            keyObject.gameObject.SetActive(true);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
            Destroy(this.gameObject);
            levelObject.gameObject.SetActive(true);
        
    }
}
