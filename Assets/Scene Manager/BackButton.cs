using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Back_Button_Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
       
    }
}
