using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotationSpeed = 1.5f;

    private float _rotationY;
    private Vector3 _offset;

    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        _rotationY = transform.eulerAngles.y;
        _offset = target.position - transform.position;

        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
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
    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput != 0)
        {
            _rotationY += horizontalInput * rotationSpeed;
        }
        else
        {
           // _rotationY += Input.GetAxis("Mouse X") * rotationSpeed * 3;
        }

        Quaternion rotation = Quaternion.Euler(0, _rotationY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
    }
}
