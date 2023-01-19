using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diologe_colider_remover : MonoBehaviour
{

    public BoxCollider trigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trigger.enabled = false;
        }
    }
}
