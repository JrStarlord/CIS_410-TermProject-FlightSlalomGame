using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject EndOfLevelMenu;
    public GameObject BackgroundImage;

    public int SecondsBeforeEndOfLevel;


    void Start()
    {
        Time.timeScale = 0;
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Canyon");
        MainMenu.SetActive(false);
        BackgroundImage.SetActive(false);
        Time.timeScale = 1;
    }

    public void OptionsButton()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        EndOfLevelMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Time.time > SecondsBeforeEndOfLevel)
        {
            Time.timeScale = 0;
            EndOfLevelMenu.SetActive(true);
            BackgroundImage.SetActive(true);
        }
    }
}