using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    private Scene scene;
    private AsyncOperation sceneloader;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneloader = SceneManager.LoadSceneAsync("Transition");
        sceneloader.allowSceneActivation = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switch (scene.name)
            {
                case "CanyonLevel":
                    TransitionScript.NextLevel = "CaveLevel";
                    sceneloader.allowSceneActivation = true;
                    break;

                case "CaveLevel":
                    TransitionScript.NextLevel = "Level 1 Concept 1";
                    sceneloader.allowSceneActivation = true;
                    break;

                case "Level 1 Concept 1":
                    SceneManager.LoadScene("EndingMenu");
                    //sceneloader.allowSceneActivation = true;

                    break;

                default:
                    break;
            }
        }
    }
}

