using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pills : Interactable
{
    [Header("Refrences")]
    public Bed Bedbool;
    public AudioSource sfx;
    public AudioClip sfxPills;
    public AudioClip sfxLookSound;
    public override void OnFocus()
    {
        sfx.PlayOneShot(sfxLookSound);
    }

    public override void OnInteract()
    {
        sfx.Stop();
        //set beds boolean to true
        //play pill rattle sound sfx
        sfx.PlayOneShot(sfxPills);
        Destroy(gameObject);
        Bedbool.pillsTaken = true;

    }

    public override void OnLoseFocus()
    {
 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
