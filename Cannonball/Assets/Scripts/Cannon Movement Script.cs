using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovementScript : MonoBehaviour
{
    public GameObject cannon;
    public GameObject barrel;
    public float rotationSpeed = 1f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        if (x != 0)
        {
            print("Held");
        }
        if (Input.GetButton("Vertical")) { 
        
        }
    }
}
