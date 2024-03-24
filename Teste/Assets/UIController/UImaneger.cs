using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImaneger : MonoBehaviour
{

    public static UImaneger instance;

    public Text lifeCount;
    public Text ItemsCount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateUI()
    {
        lifeCount.text = string.Format("Vidas: {0}", PlayerManeger.instance.Atuallive);
        ItemsCount.text = string.Format("Items: {0}", PlayerManeger.instance.AtualItems);
    }


}

