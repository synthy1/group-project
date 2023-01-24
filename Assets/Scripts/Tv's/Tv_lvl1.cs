using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tv_lvl1 : Interactable
{
    Movement lvlBool;
    public GameObject player;
    public GameObject tpLocation;
    public GameObject tvScreen;
    public Material tvScreenMat;

    private void Start()
    {
        lvlBool = player.GetComponent<Movement>();
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {


        if (lvlBool.lvl1Cmp == false && lvlBool.readControls == true)
        {
            player.transform.position = tpLocation.transform.position;
            player.transform.rotation = tpLocation.transform.rotation;
            lvlBool.inLobby = false;
        }

        if (lvlBool.readControls == false)
        {
            lvlBool.readControls = true;
            tvScreen.GetComponent<MeshRenderer>().material = tvScreenMat;
        }
    }

    public override void OnLoseFocus()
    {

    }

}
