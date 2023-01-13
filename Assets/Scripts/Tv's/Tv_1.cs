using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv_1 : Interactable
{
    public GameObject player;
    public GameObject tpLocation;
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        player.transform.position = tpLocation.transform.position;
        Debug.Log("tp");
    }

    public override void OnLoseFocus()
    {

    }
}
