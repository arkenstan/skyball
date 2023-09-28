using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ball Props", menuName = "Props/Ball")]
public class BallAttributes : ScriptableObject
{
    public bool canJump = true;
    public bool canMoveX = false;
    public bool canMoveZ = false;

    public bool CanMove
    {
        get { return canMoveX && canMoveZ; }
        set
        {
            canMoveX = value;
            canMoveZ = value;
        }
    }
}
