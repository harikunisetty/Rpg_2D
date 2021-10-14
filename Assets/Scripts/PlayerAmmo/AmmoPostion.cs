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
        Transform ammospawn = AmmoManager.SpawnAmmo(fireTrans.position, Quaternion.identity);
        ammospawn.GetComponent<Rigidbody2D>().AddForce(fireTrans.right * speed,ForceMode2D.Impulse);

    }
    /*GameObject Go = Instantiate(ammo, fireTrans.position, Quaternion.identity, this.transform);
    Go.GetComponent<Rigidbody2D>().AddForce(this.transform.InverseTransformVector(Vector3.right)* 15f, ForceMode2D.Impulse);
    Debug.Log("Fire");*/
}
