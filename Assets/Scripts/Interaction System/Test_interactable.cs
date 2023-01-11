using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_interactable : Interactable
{
    public override void OnFocus()
    {
        Debug.Log("looking at" + gameObject.name);
    }

    public override void OnInteract()
    {
        Debug.Log("iteracted with" + gameObject.name);
    }

    public override void OnLoseFocus()
    {
        Debug.Log("stoped looking at" + gameObject.name);
    }

}
