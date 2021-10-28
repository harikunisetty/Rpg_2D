using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 40f;
  /*  [SerializeField] float maxVelocity = 5f;*/
    private float xInput, yInput;
    [SerializeField] bool facingRight;
    Vector2 moveMent;

    [Header("Components")]
    [SerializeField] new Rigidbody2D rigidbody2D;
    [SerializeField] Animator anim;


    [Header("Attack")]
    [SerializeField] bool isAttacking;
    [SerializeField] AttackType attackType;


    [Header("Special Attack")]
    [SerializeField] LayerMask splLayerMask;
    [SerializeField] bool canSplAttack01, canFireSplAttack01;
    [SerializeField] float delayTime = 3f;

    public enum AttackType
    {
        Normal, Attack, SPLAttack01
    }
   
    void Start()
    {
        isAttacking = false;
        canSplAttack01 = false;
        canFireSplAttack01 = true;
        attackType = AttackType.Normal;
        

        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        xInput = Input.GetAxis("Horizontal") *speed;
        yInput= Input.GetAxis("Vertical") *speed;

        rigidbody2D.velocity = new Vector2(xInput, yInput);

        anim.SetFloat("Horizontal",Mathf.Abs(rigidbody2D.velocity.x));
        anim.SetFloat("Vertical",yInput);

        if (xInput > 0 && !facingRight)
        {
            FilpCharacter();
        }
        else if (xInput < 0 && facingRight)
        {
            FilpCharacter();
        }

        if (Input.GetKeyDown(KeyCode.X) && isAttacking == false)
        {
            isAttacking = true;
            PlayerAttack();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (canSplAttack01)
            {
                if (canFireSplAttack01)
                {
                    isAttacking = true;
                    canFireSplAttack01 = false;
                    PlayerAttack();
                }
            }
        }


    }
    public void FilpCharacter()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
           GameManager.Instance.UpdateCoins();
        }

        if (other.CompareTag("SPLAttack01"))
        {
            canSplAttack01 = true;
            Destroy(other.gameObject);
        }
        canSplAttack01 = true;
    }
    void PlayerAttack()
    {
        /*if (Input.GetKeyDown(KeyCode.X))
            attackType = AttackType.Attack;*/
        if (Input.GetKeyDown(KeyCode.C))
            attackType = AttackType.SPLAttack01;

        switch (attackType)
        {
            case AttackType.Attack:
                /*anim.SetTrigger("Attack");*/

                break;
            case AttackType.SPLAttack01:
                anim.SetTrigger("SPLAttack");

                Invoke("SPLDelayCallAttack", 0.525f);
                break;
            default:
                break;
        }

        isAttacking = false;
        attackType = AttackType.Normal;
    }

    void SPLDelayCallAttack()
    {
        CancelInvoke();

        var sphCollider = Physics.OverlapSphere(transform.position, 3.5f, splLayerMask);
        if (sphCollider.Length > 0)
        {
            foreach (var coll in sphCollider)
            {
                Debug.Log("touchcircle");
            }
        }

        Invoke("DelaySPLAttack", delayTime);
    }

    void DelaySPLAttack()
    {
        CancelInvoke();
        canFireSplAttack01 = true;
    }

}
