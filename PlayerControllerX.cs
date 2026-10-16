using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("Setting")]
    public float rotationSpeed;
    public float speed;

    [Space(10)]
    [Header("References")]
    public float verticalInput;
    public float horizontalInput;

    void FixedUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move forward constantly
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Only tilt when there is vertical and horizontal input
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * horizontalInput * rotationSpeed * Time.deltaTime);
    }
}