using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class BottleControllerNoAnim : NetworkBehaviour
{
    private CharacterController _Chc;
    private Vector3 _VMotion;

    public float WalkSpeed = 5.0f;
    public float SprintSpeed = 10.0f;
    private float _CurrentSpeed;

    private float _Grav;

    public GameObject CameraContainer;
    public ControllerManager controllerManager;

    public GameObject ControllerManager;
    private void Start()
    {
        _Chc = gameObject.GetComponent<CharacterController>();
        GameObject.Find("ControllerManager").GetComponent<ControllerManager>();
    }

    private void Update()
    {

        if(isLocalPlayer)
        {
            //sprint
            if(controllerManager != null)
            {
                if(Input.GetAxis("Vertical") > 0.1f & controllerManager.GetButtonState(controllerManager.SprintKey))
                {
                    _CurrentSpeed = SprintSpeed;
                }
                else
                {
                    _CurrentSpeed = WalkSpeed;
                }
            }
            else
            {
                Debug.Log("controllerManager == null");
                ControllerManager = GameObject.Find("ControllerManager");
                controllerManager = ControllerManager.GetComponent<ControllerManager>();
            }


            //grav calculation
            _Grav = 5 * 10 * Time.deltaTime;

            //movement
            Vector3 movementX = CameraContainer.transform.right * Input.GetAxis("Horizontal");
            Vector3 movementZ = CameraContainer.transform.forward * Input.GetAxis("Vertical");
            Vector3 movement = movementX + movementZ;
            _VMotion = new Vector3(-movement.x, -_Grav, -movement.z);
            _Chc.Move(_VMotion * _CurrentSpeed * Time.deltaTime);
        }
        else
        {
            CameraContainer.SetActive(false);
            this.gameObject.GetComponent<BottleControllerNoAnim>().enabled = false;
        }

    }
}
