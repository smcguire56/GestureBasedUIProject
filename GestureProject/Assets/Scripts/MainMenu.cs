using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject option;
    public GameObject menu;


    public void PlayGame()
    {
        SceneManager.LoadScene("RaceArea");
    }
    public void Options()
    {
        menu.SetActive(false);
        option.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
