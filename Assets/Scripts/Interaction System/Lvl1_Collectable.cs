using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl1_Collectable : Interactable
{
    Movement player;
    public GameObject PH_1;
    public GameObject PH_2;
    public GameObject rats;
    public GameObject walls;
    MeshRenderer[] meshes;
    public Material eyes;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        meshes = walls.GetComponentsInChildren<MeshRenderer>();

        foreach(MeshRenderer mesh in meshes)
        {
            mesh.material = eyes;
        }
        rats.SetActive(false);
        Destroy(gameObject);
        player.lvl1Cmp = true;
        PH_1.SetActive(false);
        PH_2.SetActive(true);
    }

    public override void OnLoseFocus()
    {

    }

}
