using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding_movement : MonoBehaviour
{
    //Refrence to camera to get sensitivity
    PlayerCam sens;

    //Mouse sensitivity values
    float followX;
    float followY;

    //the direction our player is facing
    public Transform orientation;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        sens = GameObject.Find("Player camera").GetComponent<PlayerCam>();
    }

    // Update is called once per frame
    void Update()
    {
        followX = sens.sensX;
        followY = sens.sensY;
        //setting the mouse value to a float and multiplying by our desired sensitivity
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * followX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * followY;

        //mapping rotation to our mouse input
        yRotation += mouseX;

        xRotation -= mouseY;

        //clamps xaxis
        xRotation = Mathf.Clamp(xRotation, 0f, 0f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
