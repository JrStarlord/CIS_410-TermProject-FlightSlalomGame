using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 25, strafeSpeed = 7, hovorSpeed = 5;
    private float activeForwardSpeed, activeStrafeSpeed, activeHovorSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        activeHovorSpeed = Input.GetAxisRaw("Hovor") * hovorSpeed;

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
    }
}
