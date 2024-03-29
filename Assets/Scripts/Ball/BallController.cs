using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public BallAttributes ballAttrs;
    public float speed = 10f;
    public float xForce = 10.0f;
    public float zForce = 10.0f;
    public float yForce = 500.0f;
    Rigidbody rb;
    Vector3 initPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementControl();
    }

    private void MovementControl()
    {
        // X Axis Movement
        float x = 0.0f;
        if (ballAttrs.canMoveX)
        {
            if (Input.GetKey(KeyCode.A))
            {
                x -= xForce;
            }

            if (Input.GetKey(KeyCode.D))
            {
                x += xForce;
            }
        }

        // Z Axis movement
        float z = 0.0f;
        if (ballAttrs.canMoveZ)
        {
            if (Input.GetKey(KeyCode.S))
            {
                z -= zForce;
            }

            if (Input.GetKey(KeyCode.W))
            {
                z += zForce;
            }
        }

        float y = 0.0f;
        if (Input.GetKeyDown(KeyCode.Space) && ballAttrs.canJump)
        {
            y = yForce;
        }

        if (ballAttrs.CanMove)
        {
            rb.AddForce(x, y, z);
        }
    }
}
