using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {


    public static float timeLeft = 4;
    public Text countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject CarControls;
    public GameObject EnemyCarControls;
    public GameObject TimerControls;

    void Start()
    {
        GetReady.Play();
        CarControls.SetActive(false);
        EnemyCarControls.SetActive(false);
        TimerControls.SetActive(false);

    }

    void Update()
    {
     
       countdown.text = "" + System.Math.Floor(timeLeft);
       

        if (timeLeft < 1)
        {
            countdown.text = "GO!";
            GoAudio.Play();
            CarControls.SetActive(true);
            TimerControls.SetActive(true);

        }
        if (timeLeft < 0)
        {
            GoAudio.Stop();
            countdown.text = "";
        }

        timeLeft -= Time.deltaTime;
    }
}
