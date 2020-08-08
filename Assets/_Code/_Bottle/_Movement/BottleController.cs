using JetBrains.Annotations;
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class BottleController : NetworkBehaviour
{
    private Animator _animator;
    public float MoveSpeed = 5.0f;
    private void Start()
    {
        _animator = this.gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isLocalPlayer)
        {
            _animator.SetFloat("HorizontalWalk", Input.GetAxis("Horizontal"));
            _animator.SetFloat("Walk", Sprint("Vertical",KeyCode.LeftShift));

            //this.gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, _animator.GetFloat("Walk") * MoveSpeed * Time.deltaTime);
        }
        else
        {
            this.gameObject.GetComponent<BottleController>().enabled = false;
            this.gameObject.GetComponentInChildren<Camera>().enabled = false;
        }
    }

    private float Sprint(string Axis, KeyCode key)
    {
        if (Input.GetAxis(Axis) > 0.1 & Input.GetKey(key))
            return 2;
        else
            return Input.GetAxis(Axis);

    }
}
