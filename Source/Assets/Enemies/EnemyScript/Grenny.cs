using UnityEngine;
using System.Collections;

public class Grenny : MonoBehaviour
{
    [Header ("Igual o Script do inimigo so que para o inimigo velha")]
    public float speed;
    Rigidbody2D rb;
    bool facingRight = false;
    bool noChao = false;
    Transform groundCheck;

    public float jumpForce = 700;
    private Animator anim;

    public bool atack = false;


    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        groundCheck = transform.Find("EnemyGroundCheck");
        anim = gameObject.GetComponent<Animator>();
    

    }


	   

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(10, 11);

        noChao = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if (!noChao)
            speed *= -1;
            
            

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (speed > 0 && !facingRight)
        {
            Flip();
        }

        else if (speed < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

         void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            atack=true;
        }else
        {
            atack=false;
        }
         anim.SetBool("Atack", atack);
    }

}
