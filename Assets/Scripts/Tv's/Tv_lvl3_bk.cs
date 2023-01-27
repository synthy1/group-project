using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv_lvl3_bk : Interactable
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
    private void Update()
    {
        if (lvlBool.lvl3Col == true)
        {

        }
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        if (lvlBool.lvl3Col == true)
        {
            player.transform.position = tpLocation.transform.position;
            player.transform.rotation = tpLocation.transform.rotation;
            lvlBool.lvl3Cmp = true;
            lvlBool.inLobby = true;
        }
    }

    public override void OnLoseFocus()
    {

    }

}
