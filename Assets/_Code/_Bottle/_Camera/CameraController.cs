using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float _yaw = 0.0f;
    private float _pitch = 0.0f;

    void Update()
    {
        _yaw += speedH * Input.GetAxis("Mouse X");
        _pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(-_pitch, _yaw, 0.0f);
    }
}
