using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangerObject : MonoBehaviour
{
    [SerializeField] bool isObjectiveCompleted;

    public bool IsObjectiveCompleted
    {
        get { return isObjectiveCompleted; }
    }

    public void Start()
    {
        isObjectiveCompleted = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isObjectiveCompleted = true;
        }
    }
}
