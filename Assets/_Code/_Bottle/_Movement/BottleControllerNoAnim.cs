using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleControllerNoAnim : MonoBehaviour
{
    private CharacterController _Chc;
    private Vector3 _VMotion;

    public float MoveSpeed = 5.0f;

    public GameObject CameraContainer;
    private void Start()
    {
        _Chc = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 movementX = CameraContainer.transform.right * Input.GetAxis("Horizontal");
        Vector3 movementZ = CameraContainer.transform.forward * Input.GetAxis("Vertical");
        Vector3 movement = movementX + movementZ;

        _VMotion = new Vector3(-movement.x, 0, -movement.z);

        _Chc.Move(_VMotion * MoveSpeed * Time.deltaTime);
    }
}
