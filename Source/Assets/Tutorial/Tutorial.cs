using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public bool active;
    public GameObject Tuto;

    // Update is called once per frame
    void Update()
    {

        if (active == true)
        {
            Tuto.SetActive(true);
        }

        else
        {
            Tuto.SetActive(false);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(Tuto, 3f);
            active = !active;

        }

    }

}