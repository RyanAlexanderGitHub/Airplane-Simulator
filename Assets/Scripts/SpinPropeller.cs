using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script spins the airplane's propeller.
*/
public class SpinPropeller : MonoBehaviour
{
    // Initialize variables
    private float speed = 1000.0f; // Propeller rotation speed

    void Update()
    {
        // Spin propeller
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
