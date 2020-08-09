using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    public KeyCode SprintKey = KeyCode.LeftShift;

    public bool GetButtonState(KeyCode keyCode)
    {
        if(Input.GetKey(keyCode))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
