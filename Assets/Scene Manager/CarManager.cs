using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour {

    //Change Car

	public GameObject[] Body_Car;
    public Material[] Material_Wheels;

    public GameObject[] Game_Object_Material_Wheels; // Only 4

    public static int Car_id = 1;

    public void Start()
    {
        Change_Model_Car(Car_id);

        AudioListener.volume = MainMenu.main_value;
    }

    private void Change_Model_Car(int Car_id)
    {
       
        for(int i=0; i<Body_Car.Length; i++)
            Body_Car[i].SetActive(false);
        Body_Car[Car_id].SetActive(true);

        for (int i = 0; i < Game_Object_Material_Wheels.Length; i++)
            Game_Object_Material_Wheels[i].GetComponent<MeshRenderer>().material = Material_Wheels[Car_id];
    }


}
