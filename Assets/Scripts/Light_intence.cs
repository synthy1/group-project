using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Light_intence : MonoBehaviour
{

    public GameObject[] sigItems;
    Ray distance;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sigItems = GameObject.FindGameObjectsWithTag("LvlColect");
        distance = Physics.Raycast(transform.position, new Vector3(sigItems[0].transform.position), out RaycastHit hit);
        
    }
}
