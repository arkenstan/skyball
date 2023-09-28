using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

public class BallManager : MonoBehaviour
{
    public BallAttributes ballAttrs;
    public GameAttributes gameAttributes;
    public TrackAttributes trackProps;
    private Rigidbody rb;

    public Vector3 initialPosition = Vector3.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ResetHandler()
    {
        transform.position = trackProps.resetPosition;
        rb.velocity = Vector3.zero;
    }

    public void GameOverHandler()
    {
        bool val = false;
        ballAttrs.canJump = val;
        ballAttrs.CanMove = val;
    }
}
