using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lobbySounds;
    Movement playerCmp;
    // Start is called before the first frame update
    void Start()
    {
        playerCmp= GameObject.Find("Player").GetComponent<Movement>();
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        lvl4.SetActive(false);
        playerCmp.jumpForce = 14f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerCmp.lvl1Cmp == false && playerCmp.inLobby == false)
        {
            lvl1.SetActive(true);
        }
        //managing cluster
        if (playerCmp.lvl1Cmp == true && playerCmp.inLobby == false)
        {
            Destroy(lvl1);
        }


        if (playerCmp.lvl2Cmp == false && playerCmp.inLobby == false)
        {
            lvl2.SetActive(true);
        }
        if (playerCmp.lvl2Cmp == true && playerCmp.inLobby == false)
        {

            Destroy(lvl2);
        }


        if (playerCmp.lvl3Cmp == false && playerCmp.inLobby == false)
        {
            lvl3.SetActive(true);
        }
        if (playerCmp.lvl3Cmp == true && playerCmp.inLobby == false)
        {

            Destroy(lvl3);
            lvl4.SetActive(true);

        }


        if(playerCmp.lvl2Cmp && playerCmp.lvl3Cmp == false && playerCmp.inLobby == false)
        {
            playerCmp.jumpForce = 20f;
        }
        else
        {
            playerCmp.jumpForce = 13f;
        }


        if(playerCmp.inLobby== true)
        {
            lobbySounds.SetActive(true);
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
        }
        else
        {
            lobbySounds.SetActive(false);

        }
    }
}
