using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 40f;
    [SerializeField] float maxVelocity = 5f;
    private float xInput, yInput;
    [SerializeField] bool facingRight;

    [Header("Components")]
    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal") * speed;
        yInput = Input.GetAxis("Vertical") * speed;

        rigidbody2D.velocity = new Vector2(xInput, yInput);

        anim.SetFloat("Speed", rigidbody2D.velocity.x);
        anim.SetFloat("Direction",rigidbody2D.velocity.y);


        if (xInput > 0 && !facingRight)
        {
            FilpCharacter();
        }
        else if (xInput < 0 && facingRight)
        {
            FilpCharacter();
        }
        
    }
    public void FilpCharacter()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SplPower"))
        {
            Destroy(collision.gameObject);
               
        }
        if (Input.GetKeyDown(KeyCode.X))
            anim.SetTrigger("SplAttack");
    }
}
