using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    public GameObject tpLocal;
    public GameObject playerLocal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerLocal.transform.position = tpLocal.transform.position;
        }
    }
}
