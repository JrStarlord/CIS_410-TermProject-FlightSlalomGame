using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    private Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switch (scene.name)
            {
                case "OpeningLevel":
                    TransitionScript.NextLevel = "CanyonLevel";
                    SceneManager.LoadScene("Transition");
                    break;

                case "CanyonLevel":
                    TransitionScript.NextLevel = "CaveLevel";
                    SceneManager.LoadScene("Transition");
                    break;

                case "CaveLevel":
                    TransitionScript.NextLevel = "SpaceLevel";
                    SceneManager.LoadScene("Transition");
                    break;

                case "SpaceLevel":
                    TransitionScript.NextLevel = "CanyonLevel";
                    SceneManager.LoadScene("Transition");
                    break;

                default:
                    break;
            }
        }
    }
}

