using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Trigger : MonoBehaviour
{
    public GameObject tvScreen;
    public Material screen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") == true)
        {
            tvScreen.GetComponent<Renderer>().material = screen;
        }
    }

}
