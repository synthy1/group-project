using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl1_Jump_End : MonoBehaviour
{

    public GameObject ambSounds;
    public GameObject lvlFin;
    public GameObject tvScreen;
    public Material lvlEndScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ambSounds.SetActive(false);
            lvlFin.SetActive(true);
            tvScreen.GetComponent<Renderer>().material = lvlEndScreen;
        }
    }
}
