using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legalItems : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collider2d)
    {
      
               if (collider2d.gameObject.CompareTag("Player"))
            {
                GetComponent<AudioSource>().Play();
                Destroy(gameObject);
                collider2d.gameObject.GetComponent<PlayerManeger>().SetLife();
            }
        
        
           
        

    }
}


