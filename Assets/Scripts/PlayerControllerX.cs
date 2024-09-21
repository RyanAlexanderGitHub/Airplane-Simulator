using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script controls the airplane's movement.
*/
public class PlayerControllerX : MonoBehaviour
{
    // Initialize variables
    private float speed = 15.0f; // Airplane movement speed
    private float rotationSpeed = 70.0f; // Rotation speed for turning or rolling
    private float verticalInput; // Stores user input
    private float horizontalInput; // Stores user input
    private float rollInput; // Stores user input

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical, horizontal, and roll input, and store in assigned variable
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal"); 
        rollInput = Input.GetAxis("Roll");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        /*
        Tilts the airplane up/down/left/right and turning left/right.

        Keybound Controls:
        W / U-Arrow : Tilt Up
        S / D-Arrow : Tilt Down
        A / L-Arrow : Turn Left
        D / R-Arrow : Turn Right
        J : Tilt Left
        L : Tilt Right
        */ 
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * (-verticalInput)); // Tilt up/down
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalInput); // Turn left/right
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed * -rollInput); // Tilt left/right
        
    }
}
