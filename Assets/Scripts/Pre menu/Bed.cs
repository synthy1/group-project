using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : Interactable
{
    public Objectives objectives;
    public bool pillsTaken = false;
    public AudioSource character;
    public AudioClip character1;
    public AudioClip character2;
    bool saidLine = false;
    public override void OnFocus()
    {
        if (pillsTaken)
        {
            if(saidLine == false)
            {
                character.PlayOneShot(character2);
                saidLine = true;
            }
        }
    }

    public override void OnInteract()
    {
        if (!pillsTaken)
        {
            character.PlayOneShot(character1);
            objectives.obj2.enabled = true;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
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
