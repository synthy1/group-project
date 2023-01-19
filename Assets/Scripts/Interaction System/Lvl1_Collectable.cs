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
    public GameObject ambSounds;
    public GameObject endTrigger;
    MeshRenderer[] meshes;
    AudioSource[] ambient;
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
        ambient = ambSounds.GetComponentsInChildren<AudioSource>();

        foreach(MeshRenderer mesh in meshes)
        {
            mesh.material = eyes;
        }
        foreach (AudioSource audio in ambient)
        {
            audio.enabled = true;
        }
        rats.SetActive(false);
        Destroy(gameObject);
        player.lvl1Cmp = true;
        endTrigger.GetComponent<BoxCollider>().enabled = true;
        PH_1.SetActive(false);
        PH_2.SetActive(true);
    }

    public override void OnLoseFocus()
    {

    }

}
