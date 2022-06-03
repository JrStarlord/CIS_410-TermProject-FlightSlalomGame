using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TransitionScript : MonoBehaviour
{

    public GameObject BackupShip;
    public static string NextLevel;
    private float WaitTime = 4.5f;
    private float Timer = 0.0f;

    private AsyncOperation sceneloader;

    void Start()
    {
        GameObject playerBox = GameObject.Find("PlayerBox");

        var CurrentShip = MainMenuScript.CurrentShip;
        if (CurrentShip == null)
        {
            CurrentShip = BackupShip;
        }

        GameObject ship = Instantiate(CurrentShip);
        ship.transform.SetParent(playerBox.transform);



        //sceneloader = SceneManager.LoadSceneAsync(NextLevel);
        //print(NextLevel);
        //sceneloader.allowSceneActivation = false;





    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > WaitTime)
        {
            //sceneloader.allowSceneActivation = true;
            SceneManager.LoadScene("LoadingScreen");
        }
    }

}
