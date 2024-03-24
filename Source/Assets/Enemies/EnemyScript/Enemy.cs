using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    PlayerController player;
    public float speed = 6;
    Rigidbody2D rb;
    bool facingRight = false;
    bool noChao = false;
    Transform groundCheck;
    public float jumpForce = 700;
    private GameObject box;
    private GameObject enemy;


    // Use this for initialization
    void Start()
    {

        //manipula a gravidade do objeto "enemy"
        rb = gameObject.GetComponent<Rigidbody2D>();
        //procura um objeto com o nome "EnemyGroundCheck"
        groundCheck = transform.Find("EnemyGroundCheck");

    }




    // Update is called once per frame
    void Update()
    {
        //as camadas que serao ignoradas
        Physics2D.IgnoreLayerCollision(10, 11);

        //verifica se o inimigo chegou no final do chao para virar a sua posicao oposta 
        noChao = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if (!noChao) { speed *= -1; }




    }

    void FixedUpdate()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        //quando a velocidade for maior e nao estiver virado para o lado esquerdo
        //ele virara para o outro lado
        if (speed > 0 && !facingRight)
        {
            Flip();
        }
        //quando a velocidade for menor e  estiver virado para o lado esquerdo
        //ele virara para o outro lado
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


}
