using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : Interactable
{
    public bool pillsTaken = false;
    public AudioSource character;
    public AudioClip character1;
    public AudioClip character2;
    public override void OnFocus()
    {
        if (pillsTaken)
        {
            character.Stop();
            character.PlayOneShot(character2);
        }

    }

    public override void OnInteract()
    {
        if (!pillsTaken)
        {
            character.PlayOneShot(character1);
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
