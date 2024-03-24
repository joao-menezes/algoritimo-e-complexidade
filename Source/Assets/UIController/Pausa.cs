using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {

	public bool IsPaused = false;
	public GameObject PauseMenu;
    	
	// Update is called once per frame
	void Update () 
    {

		if (IsPaused == true)
         {

			PauseMenu.SetActive (true);
			Time.timeScale = 0f;


        } else 
		{   
			PauseMenu.SetActive (false);
			Time.timeScale = 1f;
        }


		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			IsPaused = !IsPaused;
		}
    }
	

}