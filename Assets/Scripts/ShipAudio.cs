using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAudio : MonoBehaviour
{
    public AudioSource jetAudio;

    void Start()
    {
        jetAudio.loop = true;
        jetAudio.Play();
    }
}
