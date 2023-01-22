using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lobbySounds;
    Movement playerCmp;
    // Start is called before the first frame update
    void Start()
    {
        playerCmp= GameObject.Find("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //managing cluster
        if (playerCmp.lvl1Cmp == true)
        {
            Destroy(lvl1);
        }

        if (playerCmp.lvl2Cmp == true)
        {
            Destroy(lvl2);
        } 

        
        if(playerCmp.lvl1Cmp == false || playerCmp.inLobby == true)
        {
            lvl2.SetActive(false);
        }
        else
        {
            lvl2.SetActive(true);
        }

        if(playerCmp.inLobby== true)
        {
            lobbySounds.SetActive(true);
        }
        else
        {
            lobbySounds.SetActive(false);
        }
    }
}
