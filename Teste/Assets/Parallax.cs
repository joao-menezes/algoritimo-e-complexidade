using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Parallax : MonoBehaviour
{
    public Transform alvo;
    public float velocidadeRelativa;
    float posicaox;


    void Start()
    {
        if(velocidadeRelativa<1)
        {
       velocidadeRelativa = 1;
        }

        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        posicaox = alvo.position.x;

    }

    void EfeitoParallax()
    {
        transform.Translate((alvo.position.x - posicaox)/velocidadeRelativa,0,0);
        posicaox = alvo.position.x;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        EfeitoParallax();
    }
}