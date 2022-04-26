using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotationSpeed = 1.5f;

    private float _rotationY;
    private Vector3 _offset;

    void Start()
    {
        _rotationY = transform.eulerAngles.y;
        _offset = target.position - transform.position;
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
