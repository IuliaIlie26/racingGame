using UnityStandardAssets.Vehicles.Car;
using UnityEngine;

public class CarControllActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject CarControl2;

    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        CarControl2.GetComponent<CarController>().enabled = true;

    }
    
}
