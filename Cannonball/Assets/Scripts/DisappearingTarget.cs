using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingTarget : MonoBehaviour
{
    public GameObject CannonBallCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (CannonBallCollision != null)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    // private void 
    private void OnTriggerEnter(Collider other)
    {
        if (CannonBallCollision != null)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
    }
    //{

    //}
}
