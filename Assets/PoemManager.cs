using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoemManager : MonoBehaviour
{

    [Header("Refrences")]
    public GameObject lineOne;
    public GameObject lineTwo;
    public GameObject lineThree;

    public GameObject col1;
    public GameObject col2;
    public GameObject col3;
    public GameObject col4;


    Movement player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();

        lineOne.SetActive(false);
        lineTwo.SetActive(false);
        lineThree.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.lvl1Cmp)
        {
            lineOne.SetActive(true);
            col1.SetActive(true);
        }

        if (player.lvl2Cmp)
        {
            lineTwo.SetActive(true);
            col2.SetActive(true);
        }

        if (player.lvl3Cmp)
        {
            lineThree.SetActive(true);
            col2.SetActive(true);
            col4.SetActive(true);
        }


    }
}
