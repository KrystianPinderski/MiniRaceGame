using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class MainMenu : MonoBehaviour {

    public Slider main_Slider;
    public int map_id = 1;
    public float[] table_MaximumSteerAngle;
    public float[] table_Topspeed;
    public Text[] show_In_Menu;

    // Use this for initialization
    void Start ()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        main_Slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

        for (int i = 0; i < show_In_Menu.Length; i++)
        {
            show_In_Menu[i].text = "MaximumSteerAngle: " + table_MaximumSteerAngle[i]+"\n" + "Topspeed: " + (table_Topspeed[i]);
        }

        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Change_Map(int _map_id)
    {
        map_id = _map_id;
    }

    public void Change_Car(int id)
    {
        CarManager.Car_id = id;

        CarController.m_MaximumSteerAngle = table_MaximumSteerAngle[id];
        CarController.m_Topspeed = table_Topspeed[id]; 

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(map_id+1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    //sound main
    public static float main_value = 1;

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        main_value = main_Slider.value;
        AudioListener.volume = main_value;
    }

}
