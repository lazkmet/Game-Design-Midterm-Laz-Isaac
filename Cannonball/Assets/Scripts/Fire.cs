using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int ammoRemaining = 0;
    public int maxAmmo = 4;
    public GameObject firingOrigin;
    public GameObject cannonball;
    void Start()
    {
        ammoRemaining = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
