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
    public GameObject ShipMenu;

    public int SecondsBeforeEndOfLevel;
    private bool InvertControls = false;

    public GameObject ship1;
    public GameObject ship2;
    public GameObject ship3;

    public static GameObject CurrentShip;


    void Start()
    {
        Time.timeScale = 0;
        CurrentShip = ship1;
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
        ShipMenu.SetActive(false);
        
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

    public void ShipMenuButton()
    {
        MainMenu.SetActive(false);
        ShipMenu.SetActive(true);
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


    public void ShipSelect(int ship)
    {
        switch (ship)
        {
            case 1:
                CurrentShip = ship1;
                break;

            case 2:
                CurrentShip = ship2;
                break;

            case 3:
                CurrentShip = ship3;
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