using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmostFinishedScript : MonoBehaviour {

    public GameObject startTrigger;
    public GameObject almostFinishedTrigger;
	void OnTriggerEnter () {

        startTrigger.SetActive(true);
        almostFinishedTrigger.SetActive(false);
	}
}
