using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [Header("Script para o Player")]
    public static PlayerController player;
    public Transform groundCheck;
    public float speed;
    public float jumpForce = 400;
    public LayerMask whatIsGround;
    private Animator anim;
    [HideInInspector]
    public bool lookingRight = true;
    private Rigidbody2D rb2d;
    public bool isGrounded = false;
    private float groundRadius = 0.2f;
    private bool Doublejump = true;
    public bool duck = false;


    void Start()
    {
        //objeto do tipo rigidBody2D serve para poder manipular 
        //sua gravidade por viade codigo
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        //objeto do tipo "animator" serve para animar algo que ja possua animcao
        anim = gameObject.GetComponent<Animator>();

    }

    //verifica a cada milisegundo a tecla pressionada para realizar uma ação
    void Update()
    {
        //chamamos os meétodo move para o Update verificar tudo a cada milissegundo
        //pára que quando o jogador parar de realizar alguma animacao 
        //ele parara naquele instante
        move();

    }


    //método que contem aquilo que faz o Player se movimentar
    void move()
    {

        //Codigo que faz o Player se movimentar esquerda e direita
        //tambem chamando sua animcao de movimento
        float horizontalForceButton = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(horizontalForceButton));

        if (duck == false)
        {
            rb2d.velocity = new Vector2(horizontalForceButton * speed, rb2d.velocity.y);
        }

        if (horizontalForceButton > 0 && lookingRight == false)
        {
            //aqui chamamos o método Flip
            Flip();
        }
        else if (horizontalForceButton < 0 && lookingRight == true)
        {

            Flip();
        }
        //Verificar se esta abaixado
        //se estiver ele coloca a velocidade do jogado para baixo para ele nao poder se movimentar 
        //enquanto abaixado
        if (Input.GetAxis("Vertical") < 0 || Input.GetKey(KeyCode.LeftControl))
        {
            speed = 0;
            rb2d.velocity = new Vector2(horizontalForceButton * speed, rb2d.velocity.y);
            duck = true;
            Doublejump = false;
        }
        else
        {
            speed = 6;
            duck = false;
        }
        anim.SetBool("Duck", duck);

        //verifica se Player esta colidindo com o isGrounded pois se estiver pula e ativa a animcao de pular
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Jump", isGrounded);

        //Permissao de pular duas vezes
        //para quando o Player está em alguma plataforma em que a variavel isGrounded seja verdadeira
        if (Input.GetButtonDown("Jump") && isGrounded == true || Input.GetKeyDown(KeyCode.W) && isGrounded == true || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            Doublejump = true;

        }
        //para quando o Player está em alguma plataforma em que a variavel isGrounded2 seja verdadeira
        //a variavel isGrounded2 foi criada com o intuito de fazer os inimigos a ignorarem a fazendo colidir apenas com o jogador
        if (Input.GetButtonDown("Jump") && isGrounded == false && Doublejump == true || Input.GetKeyDown(KeyCode.W) && isGrounded == false && Doublejump == true || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == false && Doublejump == true)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            Doublejump = false;


        }

       
    }

    //método que faz com que o sprite do persogame vire para o lado oposto de onde seu eixo x está apontado 
    //se ele estiver para a esquerda e o jogador pressionar para a direita ele sera virado para a direita
    //e vice e versa
    void Flip()
    {
        lookingRight = !lookingRight;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
    }




}