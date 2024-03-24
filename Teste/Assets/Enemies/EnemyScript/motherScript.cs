using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherScript : MonoBehaviour
{
    //variavel que pegara aquilo se tornara alvo
    public Transform target;
    //velocidade do objeto
    public float speed = 6f;
    private Transform myTransform;
    public motherScript mother;

    void Start()
    {
        myTransform = this.GetComponent<Transform>();



    }

    void Update()
    {
        //as camadas que serao ignoradas
        Physics2D.IgnoreLayerCollision(12, 8);
        Physics2D.IgnoreLayerCollision(12, 11);
        Physics2D.IgnoreLayerCollision(12, 10);
        //rotaciona para a posicao do jogador
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcao para a rotacao original



        myTransform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }


}