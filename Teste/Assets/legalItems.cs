using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legalItems : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D collider2d)
{

     //quando colidor com o player sera acrescentado mais um em sua vida
    if(collider2d.gameObject.CompareTag("Player"))
    {
      GetComponent<AudioSource>().Play();
      Destroy(gameObject,0.1f);
            collider2d.gameObject.GetComponent<PlayerManeger>().Setlife();
           
      

  
    }
   
}

}
