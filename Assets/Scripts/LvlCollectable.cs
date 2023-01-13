using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlCollectable : Interactable
{
    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        Destroy(gameObject);
    }

    public override void OnLoseFocus()
    {

    }

}
