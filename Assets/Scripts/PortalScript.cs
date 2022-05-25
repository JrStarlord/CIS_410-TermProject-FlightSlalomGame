using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("TELEPORTED");
            Scene scene = SceneManager.GetActiveScene();
            print(scene.name);
            

            switch (scene.name)
            {
                case "CanyonLevel":
                    SceneManager.LoadScene("CaveLevel");
                    break;

                case "CaveLevel":
                    SceneManager.LoadScene("Level 1 Concept 1");
                    break;

                case "Level 1 Concept 1":
                    SceneManager.LoadScene("EndingMenu");
                    break;

                default:
                    break;
            }
        }
    }
}

