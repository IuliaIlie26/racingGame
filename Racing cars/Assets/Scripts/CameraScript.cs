using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject player;
    public float xAxis, yAxis, zAxis;

    void Update () {

        xAxis = player.transform.eulerAngles.x;
        yAxis = player.transform.eulerAngles.y;
        zAxis = player.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(0f, yAxis, 0f);
    }
}
