using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1_Collectable : Interactable
{
    Movement player;
    public GameObject PH_1;
    public GameObject PH_2;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        Destroy(gameObject);
        player.lvl1Cmp = true;
        PH_1.SetActive(false);
        PH_2.SetActive(true);
    }

    public override void OnLoseFocus()
    {

    }

}
