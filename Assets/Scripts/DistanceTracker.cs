using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    string distanceLabel = "";
    string observerLabel = "";
    private Vector3 startPosition;


    void Start()
    {
        startPosition = transform.position;
        observerLabel = "No checkpoint yet";
    }


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 1000, 20), distanceLabel);
        GUI.Label(new Rect(10, 30, 1000, 20), observerLabel);
    }


    void Update()
    {
        Vector3 currentPosition = transform.position;
        float changeInDistance = Vector3.Distance(currentPosition, startPosition);
        int rounded = (int)Mathf.Round(changeInDistance / 10);


        distanceLabel = "Distance traveled: " + rounded + "m";

        if (rounded % 10 == 0 && rounded > 0)
        {
            observerLabel = "Reached checkpoint at " + rounded +"m";
        }
    }
}
