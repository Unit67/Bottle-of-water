using Mirror;
using Mirror.Websocket;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : NetworkBehaviour
{
    [SerializeField]
    private GameObject _Player2;

    public void SpawnPlayer2()
    {
        CmdSpawnPlayer2();
    }

    [Command]
    void CmdSpawnPlayer2()
    {
        GameObject instantiatedPlayer = (GameObject)Instantiate(_Player2, Vector3.zero, Quaternion.identity);
        NetworkServer.Spawn(instantiatedPlayer);
    }
    
}
