using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int ammoRemaining = 0;
    public int maxAmmo = 4;
    public int maxPower = 100000;
    public int existingBalls = 0;
    public float powerGain = 40;
    public GameObject firingOrigin;
    public GameObject cannonball;
    public AudioSource boomSound;
    public UIScript firingDisplay;
    private const float BASE_POWER = 20f;
    private int framesHeld = 0;
    private float powerPercent = BASE_POWER;
    void Start()
    {
        ammoRemaining = maxAmmo;
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
                powerPercent = BASE_POWER;
                framesHeld += 1;
            }
            else if (powerPercent < 100){
                powerPercent += powerGain * Time.deltaTime;
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (ammoRemaining > 0) {
                fireCannon(firingOrigin);
            }
        }
    }
    void fireCannon(GameObject origin) {
        //Fire the ball:
        GameObject newBall = Instantiate(cannonball, origin.transform.position, origin.transform.rotation);
        ammoRemaining--;
        existingBalls++;
        newBall.tag = "cannonball";
        Rigidbody ball = newBall.GetComponent<Rigidbody>();
        Vector3 firingVelocity = origin.transform.rotation * Vector3.up;
        ball.AddForce(firingVelocity * maxPower * (powerPercent/100));

        //Other firing effects:
        boomSound.Play();
        firingDisplay.decrementAmmo();
    }
}
