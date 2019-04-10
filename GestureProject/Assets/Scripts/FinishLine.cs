using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishLine : MonoBehaviour
{

    public CarController car;
    public GameObject winUI;
    public GameObject loseUI;
    private AudioSource[] allAudioSources;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (gameObject.name.Equals("Car"))
        {
            winUI.SetActive(true);
            car.UpdateTopSpeed();
            Time.timeScale = 0.0f;
            StopAllAudio();

        }
        else if (gameObject.name.Equals("OtherCar"))
        {
            loseUI.SetActive(true);
            car.UpdateTopSpeed();
            Time.timeScale = 0.0f;
            StopAllAudio();
        }
    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
}
