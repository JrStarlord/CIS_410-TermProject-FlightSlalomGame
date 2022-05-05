using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public int invert = -1; //-1 to invert controlls, place as option in menu.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal,/*flip to invert controlls->*/ -invert * vertical, 0);
        Vector3 finalDirection = new Vector3(horizontal, -invert * vertical, 10.0f);

        transform.position += direction * movementSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection), Mathf.Deg2Rad * 50.0f);
    }
}
