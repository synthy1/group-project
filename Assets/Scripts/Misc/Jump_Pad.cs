using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Pad : MonoBehaviour
{
    public float force;
    Rigidbody rigidbody;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") == true)
        {
            rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

    private void Start()
    {
        rigidbody = GameObject.Find("Player").GetComponent<Rigidbody>();
    }
}
