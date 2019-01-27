using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject MainCam;
    
    public GameObject FPCam;
    public int CamMode;

    void Update()
    {
        if (Input.GetButtonDown("ChangeCamera"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode ++;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            MainCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FPCam.SetActive(true);
            MainCam.SetActive(false);
        }
       

    }
}
