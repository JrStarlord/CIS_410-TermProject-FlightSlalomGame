using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject EndOfLevelMenu;
    public GameObject BackgroundImage;
    public GameObject LevelSelectMenu;

    public int SecondsBeforeEndOfLevel;
    private bool InvertControls = false;


    void Start()
    {
        Time.timeScale = 0;
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("CanyonLevel");
        /*MainMenu.SetActive(false);
        BackgroundImage.SetActive(false);
        Time.timeScale = 1;*/
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
        LevelSelectMenu.SetActive(false);
        
    }

    public void QuitButton()
    {
        Application.Quit();
    }


    public void LevelMenuButton()
    {
        MainMenu.SetActive(false);
        LevelSelectMenu.SetActive(true);
    }


    public void LevelSelect(int level)
    { 
        switch(level)
        {
            case 1:
                Time.timeScale = 1;
                UnityEngine.SceneManagement.SceneManager.LoadScene("CanyonLevel");
                break;

            case 2:
                Time.timeScale = 1;
                UnityEngine.SceneManagement.SceneManager.LoadScene("CaveLevel");
                break;

            case 3:
                Time.timeScale = 1;
                // load third level scene
                break;

            default:
                break;
        }
    }





    void Update()
    {
        if (SecondsBeforeEndOfLevel != 0 && Time.time > SecondsBeforeEndOfLevel)
        {
            Time.timeScale = 0;
            EndOfLevelMenu.SetActive(true);
            BackgroundImage.SetActive(true);
        }
    }
}