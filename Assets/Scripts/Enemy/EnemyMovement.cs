using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    
    [SerializeField] float xSpeed;
    [SerializeField] float Offset;
    [SerializeField] float distanceFormPlayer;
    [SerializeField] Transform Player;

    [Header("AiAttack")]

    public GameObject bullet;
    public GameObject bulletParent;
    [SerializeField] float ShootRange;
    [SerializeField] float fireRate;
    [SerializeField] float nextAtacckTime;

    [SerializeField] EnemyHealth enemyHealth;
    /*[SerializeField] float Hitvalue = 10f;*/

    [SerializeField] GameObject pickEffect;
    [SerializeField] float restTime;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyHealth = GetComponent<EnemyHealth>();
        nextAtacckTime = fireRate;
    }

    private void Update()
    {
        if (Player == null)
            return;

        distanceFormPlayer = Vector2.Distance(Player.position, transform.position);

        if (distanceFormPlayer < Offset)
        {
            if (distanceFormPlayer > ShootRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, Player.position, xSpeed);
            }
            else if (distanceFormPlayer <=ShootRange)
            {
                nextAtacckTime -= Time.deltaTime;
                if (nextAtacckTime <= 0)
                {
                    nextAtacckTime = restTime;
                    Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
                }

            }
        }       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, Offset);
        Gizmos.DrawWireSphere(transform.position, ShootRange);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // GameControl.health -= 1;
            enemyHealth.AiDamage(10f);
        }
            
        if (other.gameObject.CompareTag("Bullet"))
        {
            Instantiate(pickEffect, transform.position, Quaternion.identity);
            enemyHealth.AiDamage(60f);
        }
    }
}
