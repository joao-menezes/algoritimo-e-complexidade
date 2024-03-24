using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class gameManeger : MonoBehaviour
{
    public static gameManeger gm;
    private int life = 3;

    //Metodo criado para verificar as vidas e reduzi-las quando o 'player' levar dano
    void Awake()
    {
        if (gm == null)
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetLife(int lifes)
    {
        life += lifes;
    }

    public int GetLife()
    {
        return life;
    }

    public void AtualizaHud()
    {
        //Quando um evento do player tomar dano o texto é atualizado
        GameObject.Find("TextLife").GetComponent<Text>().text = life.ToString();
    }

}