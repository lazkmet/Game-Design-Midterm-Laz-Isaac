using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CannonMovementScript : MonoBehaviour
{
    public GameObject cannon;
    public GameObject barrel;
    public float rotationSpeed = 5f;
    public float sideLimit = 50f;
    public float upLimit = 10f;
    public Vector3 cannonRotation = Vector3.zero;
    public Vector3 barrelRotation = new Vector3(0,0,45);
    private void Start()
    {
        cannon.transform.eulerAngles = cannonRotation;
        barrel.transform.eulerAngles = barrelRotation;
    }
    void Update()
    {
        //Scripting solution provided by: https://answers.unity.com/questions/799824/oafatwhy-does-transformrotationx-45-not-work.html
        cannonRotation.y += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        cannonRotation.y = Mathf.Clamp(cannonRotation.y, -sideLimit, sideLimit);
        barrelRotation.y = cannonRotation.y;

        barrelRotation.z -= Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        barrelRotation.z = Mathf.Clamp(barrelRotation.z, upLimit, 90);

        cannon.transform.eulerAngles = cannonRotation;
        barrel.transform.eulerAngles = barrelRotation;
    }
}
