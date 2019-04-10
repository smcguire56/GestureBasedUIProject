using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public GameManagerScript GMS;
    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    private bool ready = false;
    // Update is called once per frame
    void Update() {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();

        if (GMS.counterDownDone == true && ready == false)
        {
            Debug.Log("start countdown");
            UpdateTimerUI();
            ready = true;
        }

        if (ready)
            UpdateTimerUI();

    }

    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = System.Math.Round(secondsCount, 2) + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

}