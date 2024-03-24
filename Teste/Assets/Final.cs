using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2d)
    {
        //quando o jogador chegar em seu destino ele ira para a tela de vitoria
        if (collider2d.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }

    }

}
