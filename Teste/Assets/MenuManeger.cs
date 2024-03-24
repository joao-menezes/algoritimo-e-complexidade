using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MenuManeger : MonoBehaviour
{
    int index = 0;
    public int totalButton = 3;
    public float yOffset = 1f;

    void Start()
    {

    }

    void Update()
    {

        //se a seta para cime for pressionada ele mudará o indice para a quantia 
        //que for pré determinada na variavel "totalButton"
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (index < totalButton - 1)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;

            }

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }

        //evento que ocorrerá quando o botao fore selecionado
        //se selecionar o indice 0 comecara o jogo 
        //mas se selecionar o indice 1 saira do jogo
        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (index == 0)
            {
                SceneManager.LoadScene(1);
            }
            else if (index == 1)
            {
                Application.Quit();


            }
        }
    }
}