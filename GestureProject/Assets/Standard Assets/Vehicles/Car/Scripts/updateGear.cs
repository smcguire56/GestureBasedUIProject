using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGear : MonoBehaviour {

    public Text myText = null;
    // Use this for initialization
    void Start()
    {
        myText.text = "Gear: 1";
    }

    public void setGear(int gear)
    {
        Debug.Log("Gear: " + gear);
        myText.text = "Gear: " + gear;
    }
}
