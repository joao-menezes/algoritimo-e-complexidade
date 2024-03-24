using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerSchollar : MonoBehaviour
{
    private int Items;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = Items.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Scholar"))
        {

            Items++;
            text.text = Items.ToString();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
