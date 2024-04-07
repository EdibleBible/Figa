using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSidescroll : MonoBehaviour
{
    [SerializeField] public float cameraSpeed = 0f;

    void Update()
    {
        Vector3 movementDirection = transform.right;
        Vector3 movement = movementDirection * cameraSpeed * Time.deltaTime;
        transform.position += movement;
    }
}
