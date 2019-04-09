using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountdown : MonoBehaviour {

    private GameManagerScript GMS;

    public void SetCountdownNow()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;
    }
}
