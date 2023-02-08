using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antigrav : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 20f, ForceMode.Force);
        
        if(gameObject.GetComponent<Rigidbody>().velocity.y > 70f)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, 70f, 0f);
        }
    }
}
