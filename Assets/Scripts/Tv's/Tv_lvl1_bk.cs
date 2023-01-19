using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv_lvl1_bk : Interactable
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
        if (lvlBool.lvl1Cmp == true)
        {
            player.transform.position = tpLocation.transform.position;
            player.transform.rotation = tpLocation.transform.rotation;
        }
    }

    public override void OnLoseFocus()
    {

    }

}
