using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkUI : MonoBehaviour
{
    public NetworkManager manager;
    public SpawnPlayer spawnPlayer;
    private Enum _PlayerChoice;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SpawnPlayer()
    {
        if (manager.isNetworkActive)
            spawnPlayer.SpawnPlayer2();
    }

    public void HostBTN()
    {
        
        manager.StartHost();
    }
    public void ClientBTN()
    {
        manager.StartClient();
    }
}
