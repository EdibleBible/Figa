using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        // Get input from keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * movementSpeed * Time.deltaTime;

        // Apply movement to the player
        transform.Translate(movement);
    }
}
