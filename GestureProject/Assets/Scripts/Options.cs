using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour {

    public GameObject option;
    public GameObject menu;

    public void Back()
    {
        option.SetActive(false);
        menu.SetActive(true);
    }
}
