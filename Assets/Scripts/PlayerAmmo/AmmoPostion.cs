using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPostion : MonoBehaviour
{

    [Header("Fire")]
    [SerializeField] float attackIntervals = 0.5f;
    [SerializeField] float nextAttack;
    [SerializeField] float timer = 0;
    [SerializeField] float speed = 20f;
    [SerializeField] Transform fireTrans;
    [SerializeField] GameObject Ammo;
    [SerializeField] bool moveRight;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Fire();


    }
    void Fire()
    {

        Transform ammospawn = AmmoManager.SpawnAmmo(fireTrans.position, Quaternion.identity);
        ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.right * speed, ForceMode2D.Impulse);

    }
}
