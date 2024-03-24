using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilegalItems : MonoBehaviour
{
    public GameObject slipper;//ele pega o objeto que for determinado na propia Unity sendo no caso o chinelo
    public GameObject mom;//ele pega o objeto que for determinado na propia Unity sendo no caso a mae
    private motherScript mother;//chama a classe da mae para ser manipulada
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.gameObject.CompareTag("Player"))
        {
            //deixa o objeto mae visivel
            mom.SetActive(true);
            //objeto do scripit da mae
            motherScript mother = FindObjectOfType(typeof(motherScript)) as motherScript;
            mother.enabled = true;//habilita o script da mae
            slipper.SetActive(true);//deixa o objeto chinelo visivel
            //emite um som para acoleta
            GetComponent<AudioSource>().Play();
            //se destroi despois de coletado
            Destroy(gameObject, 0.1f);





        }

    }



}
