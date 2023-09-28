using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Track Props", menuName = "Props/Track")]
public class TrackAttributes : ScriptableObject
{
    public Vector3 initialPosition = Vector3.zero;
    public Vector3 resetPosition = Vector3.zero;
}
