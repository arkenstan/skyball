using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCollision : MonoBehaviour
{
    public GameEvent trackCollisionEvent,
        finishEvent;

    public BallAttributes ballAttrs;

    void SetJump(bool val)
    {
        ballAttrs.canJump = val;
    }

    void SetMove(bool val)
    {
        ballAttrs.CanMove = val;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "start")
        {
            SetJump(true);
            SetMove(true);
        }
        else if (other.gameObject.tag == "Track")
        {
            SetJump(true);
        }
        else if (other.gameObject.tag == "finish")
        {
            finishEvent.Raise();
        }
    }

    void OnCollisionExit(Collision other) => SetJump(false);
}
