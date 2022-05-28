using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("TELEPORTED");
            UnityEngine.SceneManagement.SceneManager.LoadScene("CaveLevel");
        }
    }
}

