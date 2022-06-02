using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAudio : MonoBehaviour
{
    public AudioSource jetAudio;
    private bool audioPlaying;

    

    void Start()
    {
        jetAudio.loop = true;
    }

    void Update()
    {
        if (Time.timeScale == 1 && !audioPlaying) {
            jetAudio.Play();
            audioPlaying = true;
        }

        if (Time.timeScale == 0)
        {
            jetAudio.Pause();
            audioPlaying = false;
        }
    }
}
