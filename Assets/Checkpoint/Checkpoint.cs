using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour {


    private float time = 0;
    public Text Current_Time;

    public GameObject[] checkpoints;
    private int j = 0;

    private int Loops = 0;
    public int Loops_Max = 2;

    public Text Loops_Text;



    void Start()
    {
        time = 0;

        Loops_Text.text = "Loops: " + "0/" + Loops_Max;

        checkpoints[j].transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;

        checkpoints[j].transform.GetChild(1).gameObject.SetActive(true);

        Time.timeScale = 1;
    }

    void Update()
    {

        time += Time.deltaTime;


        if (Loops_Max == Loops)
        {
            print("End Game");
            Current_Time.text = "Your Full Time:\n" + time;

            Time.timeScale = 0;

            foreach (AudioSource audioSource in GameObject.FindSceneObjectsOfType(typeof(AudioSource)))
            {
                audioSource.enabled = false;
            }

        }
        if (j > checkpoints.Length)
        {

            j = 0;
            checkpoints[j].transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;

            checkpoints[j].transform.GetChild(1).gameObject.SetActive(true);

        }
    }

    public void Next_Checkpoint()
    {
        print("Next_Checkpoint");

        if (j == checkpoints.Length)
        {

            Current_Time.text = "Your Current Time:\n" + time + "\n" + "Checkpoints: " + j + "/" + checkpoints.Length;
            StartCoroutine(Wait());

            Loops++;
            Loops_Text.text = "Loops: " + Loops + "/" + Loops_Max;

            j++;

        }
        else
        {
            checkpoints[j].transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;

            checkpoints[j].transform.GetChild(1).gameObject.SetActive(true);

            Current_Time.text = "Your Current Time:\n" + time + "\n" + "Checkpoints: " + j + "/" + checkpoints.Length;

            StartCoroutine(Wait());

            j++;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Current_Time.text = "";
    }

   



}
