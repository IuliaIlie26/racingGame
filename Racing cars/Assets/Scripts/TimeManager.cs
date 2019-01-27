using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour {

    public static float timeLeft = 91;
    public Text lapTime;
   
	void Update () {
        timeLeft -= Time.deltaTime;
        lapTime.text = "Time left: " + System.Math.Floor(timeLeft) + " sec";
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    void GameOver() { }
}
