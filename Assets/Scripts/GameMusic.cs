using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource levelMusic;
    private bool audioPlaying;

    void Start()
    {
        levelMusic.loop = true;
    }

    void Update()
    {
        if (Time.timeScale == 1 && !audioPlaying)
        {
            levelMusic.Play();
            audioPlaying = true;
        }

        if (Time.timeScale == 0)
        {
            levelMusic.Pause();
            audioPlaying = false;
        }
    }
}