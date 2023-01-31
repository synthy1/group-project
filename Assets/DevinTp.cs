using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevinTp : MonoBehaviour
{
    bool hasTped = false;
    public GameObject player;
    public GameObject tpLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!hasTped)
            {
                player.transform.position = tpLocation.transform.position;
                hasTped = true;
            }
        }
    }
}
