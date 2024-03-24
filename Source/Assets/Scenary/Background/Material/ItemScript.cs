using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    // Start is called before the first frame update
    //Sistema de coleta de items 
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        }

    }
}
