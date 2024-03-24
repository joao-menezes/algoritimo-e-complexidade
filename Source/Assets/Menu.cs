using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{

    //Carrega a cena determinada pelo numero colocado no int
    public void loadScene(int cena)
    {
        SceneManager.LoadScene(cena);
    }
    //sai do jogo
    public void Exit()
    {
        Application.Quit();
    }

    //Volta para o menu inicial
    public void GoBack()
    {

        SceneManager.LoadScene(0);

    }




 
}
