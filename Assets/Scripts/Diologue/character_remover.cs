using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_remover : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
