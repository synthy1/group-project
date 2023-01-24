using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scary_Iris : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") == true)
        {
            Destroy(gameObject);
        }
    }
    
}
