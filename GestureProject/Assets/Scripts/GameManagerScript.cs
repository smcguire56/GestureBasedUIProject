using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GameManagerScript : MonoBehaviour {

    public bool counterDownDone = false;
    public CarController car;
    public CarController Othercar;
	
	// Update is called once per frame
	void Update () {
        if (counterDownDone)
        {
            car.m_Topspeed = 200.0f;
            Othercar.m_Topspeed = 80.0f;
            counterDownDone = false;

        }
    }
}
