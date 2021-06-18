using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private GameObject pickUpGraphics;
    private bool canPickUp;
    private GameObject checkpoint;
    private GameObject newcheckpoint;

    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
        Vector3 pos = tr.position;
        checkpoint = GameObject.Find("spawnpoint");
        newcheckpoint = checkpoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WeaponManager weaponManager = other.GetComponent<WeaponManager>();
            NewCheckPoint();
        }
    }

    void NewCheckPoint()
    {
        if (checkpoint != null)
        {
            Destroy(checkpoint);
            Instantiate(newcheckpoint, tr);
        }
    }
}
