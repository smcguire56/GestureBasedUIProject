using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogueRPMConverter : MonoBehaviour {

    static float minAngle = -180;
    static float maxAngle = -453;
    static AnalogueRPMConverter thisSpeedo;

    // Use this for initialization
    void Start()
    {
        thisSpeedo = this;
    }

    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);
    }

    public static void ResetSpeed(float min, float max)
    {
        float speed = 0;
        ShowSpeed(speed, min,  max);
    }

}
