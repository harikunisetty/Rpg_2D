using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPostion : MonoBehaviour
{

    [Header("Fire")]
    [SerializeField] float attackIntervals = 0.5f;
    [SerializeField] float speed = 20f;
    [SerializeField] Transform fireTrans;
    [SerializeField] GameObject Ammo;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Fire();
    }
    void Fire()
    {
        for(int i=0; i<=2; i++)
        {
            Transform ammospawn = AmmoManager.SpawnAmmo(fireTrans.position, Quaternion.identity);
            /*ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.forward * speed, ForceMode2D.Impulse);*/

            switch (i)
            {
                case 0:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.right * speed + new Vector3(0f, -90f, 0f));
                    break;
                case 1:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.right * speed + new Vector3(0f, 0f, 0f));
                    break;

                case 2:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.right * speed + new Vector3(0f, 90, 0f));
                    break;
            }
        }
       

    }
   
}
