using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_3_Colectable : Interactable
{
    [Header("Refrences")]
    Movement player;
    public GameObject dv_1;
    public GameObject an_1;
    public GameObject dv_2;
    public GameObject an_2;
    public override void OnFocus()
    {
        
    }

    public override void OnInteract()
    {
        player.lvl3Col = true;
        dv_1.SetActive(false);
        an_1.SetActive(false);
        dv_2.SetActive(true);
        an_2.SetActive(true);
    }

    public override void OnLoseFocus()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
