using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class HumanController : NetworkBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = this.gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if(isLocalPlayer)
        {
            _animator.SetFloat("Walk", Input.GetAxis("Vertical"));
            _animator.SetFloat("HorizontalWalk", Input.GetAxis("Horizontal"));

            if(Input.GetAxis("Vertical") > 0.1 & Input.GetKey(KeyCode.LeftShift))
            {
                _animator.SetFloat("Walk", 3);
            }
        }
    }
}
