using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Turn : MonoBehaviour
{
    Camera cam;
    // Update is called once per frame

    void Start()
    {
        cam = GameObject.Find("Player camera").GetComponent<Camera>();
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f,cam.transform.rotation.eulerAngles.y,0f);
    }
}
