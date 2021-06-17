using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PauseMenu : NetworkBehaviour
{
    public static bool isOn = false;

    private NetworkManager networkmanager;

    private void Start()
    {
        networkmanager = NetworkManager.singleton;
    }

    public void LeaveRoomButton()
    {
        if(isClientOnly)
        {
            networkmanager.StopClient();
        }
        else
        {
            networkmanager.StopHost();
        }
    }
}
