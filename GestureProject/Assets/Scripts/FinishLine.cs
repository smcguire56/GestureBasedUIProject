using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishLine : MonoBehaviour
{

    public CarController car;
    public GameObject winUI;
    private bool WinnerFound = false;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        Debug.Log("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        Debug.Log("Their relative velocity is " + collisionInfo.relativeVelocity);

        if (gameObject.name.Equals("Car") && WinnerFound == false)
        {
            Debug.Log("you win");
            WinnerFound = true;
            winUI.SetActive(true);
            car.UpdateTopSpeed();

        }

        if (gameObject.name.Equals("OtherCar") && WinnerFound == false)
        {
            Debug.Log("you lose");
            WinnerFound = true;
            winUI.SetActive(false);
            car.UpdateTopSpeed();

        }
    }

}
