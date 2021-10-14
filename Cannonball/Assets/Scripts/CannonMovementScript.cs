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
        float y = Input.GetAxis("Vertical");
        if (x != 0)
        {
            Vector3 rotation = new Vector3(0, rotationSpeed * x, 0);
            if (Abs(cannon.EulerAngles.y) < 50 || x*cannon.EulerAngles.y < 0) {
                cannon.transform.Rotate(rotation, Space.Local);
            }
        }
        if (y != 0) {
            Vector3 rotation = new Vector3();
            if (true)
            {
               barrel.transform.Rotate(rotation, Space.Local);
            }
        }
    }
}
