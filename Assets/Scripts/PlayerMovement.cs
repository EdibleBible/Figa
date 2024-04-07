using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    [SerializeField] private CameraSidescroll cameraSidescroll;
    private Vector3 movement;
    [SerializeField] private float untilAutoMovementInterval = 1f;
    private float untilAutoMovementIntervalDynamic;
    [SerializeField] private GameObject parent;

    private void Start()
    {
        untilAutoMovementIntervalDynamic = untilAutoMovementInterval;
    }

    void Update()
    {
        // Get input from keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (untilAutoMovementIntervalDynamic <= 0 && horizontalInput == 0 && verticalInput == 0)
        {
            movement = transform.right * cameraSidescroll.cameraSpeed * Time.deltaTime;
            parent.transform.Translate(movement);
        } else if (horizontalInput != 0 || verticalInput != 0)
        {
            untilAutoMovementIntervalDynamic = untilAutoMovementInterval;
            movement = new Vector3(horizontalInput, verticalInput, 0f) * movementSpeed * Time.deltaTime;
            parent.transform.Translate(movement);
                float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        } else
        {
            untilAutoMovementIntervalDynamic -= Time.deltaTime;
        }
    }
}
