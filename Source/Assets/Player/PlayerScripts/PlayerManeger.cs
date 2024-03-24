using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class PlayerManeger : MonoBehaviour
{

    public static PlayerManeger player;
    private Animator anim;
    public int Atuallive = 3;
    public int AtualItems;
    public Text Textlife;
    public Text TextItems;


    void Start()
    {
        //anim serve para trocar a animaçao quando necessario 
        anim = gameObject.GetComponent<Animator>();
        Textlife.text = Atuallive.ToString();
        TextItems.text = AtualItems.ToString();
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {

            Atuallive -=1;
            anim.SetTrigger("Damage");
            Textlife.text = Atuallive.ToString();
        }

        if (collision.gameObject.CompareTag("Mother"))
        {
            SceneManager.LoadScene(1);
            Atuallive -=1;
        }



        if (Atuallive <= 0)
        {
            SceneManager.LoadScene(2);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Die"))
        {
            SceneManager.LoadScene(4);
        }

        if (collision.gameObject.CompareTag("grenny"))
        {

            Atuallive -=1;
            anim.SetTrigger("Damage");
            Textlife.text = Atuallive.ToString();
        }

    }

    public void SetLife()
    {
        if (Atuallive < 3)
        {
            Atuallive++;
            Textlife.text = Atuallive.ToString();
        }

    }

    public void setSchool()
    {
        AtualItems++;
        TextItems.text = AtualItems.ToString();

    }



}