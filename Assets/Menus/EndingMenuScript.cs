using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingMenuScript : MonoBehaviour
{
    public GameObject EndingMenu;


    void Start()
    {
        Time.timeScale = 0;
        LoadEndingMenu();
    }

    public void LoadEndingMenu()
    {
        EndingMenu.SetActive(true);

    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1 Concept");

    }

    public void MainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

}
