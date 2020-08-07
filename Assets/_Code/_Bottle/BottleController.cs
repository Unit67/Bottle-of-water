using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class BottleController : NetworkBehaviour
{
    private Animator _animator;

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
