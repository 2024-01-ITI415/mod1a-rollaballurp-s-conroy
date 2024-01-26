using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
// Speed at which player moves

    public float speed = 0;

// Rigidbody of player

    private Rigidbody rb;

// Movement along X and Y axes

    private float movementX;
    private float movementY;


    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody>();

    }

// Move input detection

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

// X and Y movement components

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

// Called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

}
