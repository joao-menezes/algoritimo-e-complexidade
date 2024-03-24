using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScolarItems : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D collider2d)
{
        //quando o player colidr com  o item escolar ele emitira um som 
        //para a coleta e depois se destrui-ra
    if(collider2d.gameObject.CompareTag("Player"))
    {
      GetComponent<AudioSource>().Play();
      Destroy(gameObject,0.1f);
      }
}

}
