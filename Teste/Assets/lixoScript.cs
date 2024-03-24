using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoScript : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D collider2d)
{
    if(collider2d.gameObject.CompareTag("Player"))
    {
      Debug.Log("colidiu");
      Destroy(gameObject,0.1f);  

    }

    void Update() {
      if(collider2d.gameObject.CompareTag("Player"))
      {
           Debug.Log("nao colidiu");
      }
    }
   
}

}
