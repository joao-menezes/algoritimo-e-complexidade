using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //Variavel feita para trabalhar com animaçoes
    public static PlayerLife player;
    private Animator anim;
    public int Maxlive;
    public int Atuallive = 3;
    public Text text;



    void Start()
    {
        //anim serve para trocar a animaçao quando necessario 
        anim = gameObject.GetComponent<Animator>();
        Atuallive = Maxlive;
        text.text = Atuallive.ToString();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("Mother"))
        {

            Atuallive--;
            anim.SetTrigger("Damage");
            text.text = Atuallive.ToString();


            if (Atuallive <= 0)
            {
                SceneManager.LoadScene(2);
            }

        }



    }


    public void SetLife()
    {
        if (Atuallive == 1 || Atuallive == 2)
        {
            Atuallive++;
            text.text = Atuallive.ToString();
        }

    }

}
