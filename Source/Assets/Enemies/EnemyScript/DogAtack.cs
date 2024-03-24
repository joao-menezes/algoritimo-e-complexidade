using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAtack : MonoBehaviour
{
    [Header("Script que trabalha com a animcao do inimigo cachorro de quando ele ataca")]
    private Animator anim;
    private bool atack = false;

    void Start()
    {

        anim = gameObject.GetComponent<Animator>();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.CompareTag("Player"))
        {
            atack = true;

        }
        else
        {
            atack = false;
        }
        anim.SetBool("Atack", atack);


    }


}
