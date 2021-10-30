using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPostion : MonoBehaviour
{
    [Header("Fire")]
    [SerializeField] float speed = 20f;
    [SerializeField] Transform fireTrans;
    // [SerializeField] float attackIntervals = 0.5f;
    // [SerializeField] GameObject Ammo;


    private float xInput;
    [SerializeField] bool facingRight;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Fire();
        }

        if (xInput > 0 && !facingRight)
            facingRight = true;
        else if (xInput < 0 && !facingRight)
            facingRight = false;
        else if (xInput < 0 && facingRight)
        {
            Debug.Log(facingRight);
            facingRight = false;
        }
        else if (xInput > 0 && facingRight)
            facingRight = true;
    }
    void Fire()
    {
        // Variable = (condition > 0) ? if true value 1 : if false value 0;
        Vector3 direction = (facingRight == true) ? direction = fireTrans.right : direction = -fireTrans.right;

        for(int i=0; i<=2; i++)
        {
            Transform ammospawn = AmmoManager.SpawnAmmo(fireTrans.position, Quaternion.identity);
           /* ammospawn.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformDirection(Vector2.right) * speed, ForceMode2D.Impulse);*/

            switch (i)
            {
                case 0:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformDirection( Vector2.right)*speed,ForceMode2D.Impulse);
                    break;
                case 1:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformDirection(Vector2.up) * speed, ForceMode2D.Impulse);
                    break;
                case 2:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformDirection(Vector2.down) * speed, ForceMode2D.Impulse);
                    break;
                case 3:
                    ammospawn.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformDirection(Vector2.left) * speed, ForceMode2D.Impulse);
                    break;
            }
        }
    }
   
}
