using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv_lvl2 : Interactable
{
    Movement lvlBool;
    public GameObject player;
    public GameObject tpLocation;

    private void Start()
    {
        lvlBool = player.GetComponent<Movement>();
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        if (lvlBool.lvl1Cmp == true && lvlBool.lvl2Cmp == false)
        {
            player.transform.position = tpLocation.transform.position;
            player.transform.rotation = tpLocation.transform.rotation;
            lvlBool.inLobby = false;
        }
    }

    public override void OnLoseFocus()
    {

    }
}
