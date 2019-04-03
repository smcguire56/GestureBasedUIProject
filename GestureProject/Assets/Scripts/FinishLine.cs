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
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        Debug.Log("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        Debug.Log("Their relative velocity is " + collisionInfo.relativeVelocity);

        if (gameObject.name.Equals("Car"))
        {
            Debug.Log("you win");
            winUI.SetActive(true);
            car.UpdateTopSpeed();
            Time.timeScale = 0.0f;
            StopAllAudio();

        }
        else if (gameObject.name.Equals("OtherCar"))
        {
            Debug.Log("you lose");
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
