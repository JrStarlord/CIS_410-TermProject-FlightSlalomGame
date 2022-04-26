using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xyController : MonoBehaviour
{
    public float hSpeed;
    public float vSpeed;
    public float amplitude;

    float m_Speed;

    private Rigidbody rb;
    public float forceMultiplyer = 200;

    private Vector3 tPos;



    // Start is called before the first frame update
    void Start()
    {
        tPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            rb.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            rb.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
        }



    }
}
