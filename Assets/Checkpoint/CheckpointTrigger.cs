using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject Object_Script;

    void Start () {
      

    }

	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            print("Trigger"); 
            other.enabled=false;
            other.transform.parent.GetChild(1).gameObject.SetActive(false);
            Object_Script.GetComponent<Checkpoint>().Next_Checkpoint();
        }
    }
}
