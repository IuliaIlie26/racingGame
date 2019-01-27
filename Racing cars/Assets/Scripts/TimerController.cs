using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public GameObject TimeControl;
    void Start()
    {
        TimeControl.SetActive(true);
    }
}
