using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv_lvl2_bk : Interactable
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
        if (lvlBool.lvl2Col == true)
        {
            player.transform.position = tpLocation.transform.position;
            player.transform.rotation = tpLocation.transform.rotation;
            lvlBool.lvl2Cmp = true;
            lvlBool.inLobby = true;
        }
    }

    public override void OnLoseFocus()
    {

    }

}
