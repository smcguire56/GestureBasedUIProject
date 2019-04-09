using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour {

    public GameObject option;
    public GameObject menu;
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void Back()
    {
        option.SetActive(false);
        menu.SetActive(true);
    }
}
