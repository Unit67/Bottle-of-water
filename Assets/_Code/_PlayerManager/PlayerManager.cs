using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Networking;
public class PlayerManager : NetworkBehaviour
{
    private NetworkManager NetworkManager;

    private void Start()
    {
        NetworkManager = this.gameObject.GetComponent<NetworkManager>();
    }
}
