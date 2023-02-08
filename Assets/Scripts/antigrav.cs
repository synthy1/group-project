using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antigrav : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.position += Vector3.up * speed;
    }
}
