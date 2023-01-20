using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl2_Collectable : Interactable
{
    Movement player;
    public GameObject LI_1;
    public GameObject LI_2;
    public GameObject birds;
    public GameObject ambSounds;
    public GameObject endTrigger;
    AudioSource[] ambient;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        ambient = ambSounds.GetComponentsInChildren<AudioSource>();

        foreach (AudioSource audio in ambient)
        {
            audio.enabled = true;
        }
        Destroy(gameObject);
        player.lvl1Cmp = true;
        endTrigger.GetComponent<BoxCollider>().enabled = true;
        LI_1.SetActive(false);
        LI_2.SetActive(true);
        birds.SetActive(false);
    }

    public override void OnLoseFocus()
    {

    }

}
