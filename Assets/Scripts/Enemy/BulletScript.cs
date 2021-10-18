using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    
    [SerializeField] GameObject player;
    [SerializeField] float lifeTime=2f;
    public float speed;
    [SerializeField] Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {       
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null)
            return;

        Vector2 moveDirection = (player.transform.position - transform.position).normalized * speed;
        rb2d.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }
    private void OnEnable()
    {
        Invoke("Die", lifeTime);
    }

    void Die()
    {
        CancelInvoke();
        gameObject.SetActive(false);
    }
}
