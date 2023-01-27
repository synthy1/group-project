using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : Interactable
{
    public bool pillsTaken = false;
    public override void OnFocus()
    {
        if (pillsTaken)
        {
            //character says they took too many
        }

    }

    public override void OnInteract()
    {
        if (!pillsTaken)
        {
            //character says i should take my pills
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
