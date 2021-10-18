using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int ammoRemaining = 0;
    public int maxAmmo = 4;
    public int maxPower = 1000;
    public float powerGain = 40;
    public GameObject firingOrigin;
    public GameObject cannonball;
    private int framesHeld = 0;
    private float powerPercent = 5.0f;
    void Start()
    {
        ammoRemaining = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            framesHeld = 0;
        }
        else if (Input.GetButton("Jump"))
        {
            if (framesHeld < 40)
            {
                framesHeld += 1;
            }
            else if (framesHeld == 40)
            {
                powerPercent = 5.0f;
                framesHeld += 1;
            }
            else if (powerPercent < 100){
                powerPercent += powerGain * Time.deltaTime;
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Fire at Power Level: " + powerPercent + "%");
        }
    }
}
