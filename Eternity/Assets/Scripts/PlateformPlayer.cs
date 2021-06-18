using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlateformPlayer : NetworkBehaviour
{ 

    private Transform tr;
    private Vector3 pos;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = tr.position;
        if(isLocalPlayer)
        {
            if (pos.y <= 1.5f)
            {
                player.RpcTakeDamage(999, player.name);
            }
        }
    }
}
