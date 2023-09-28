using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutofBounds : MonoBehaviour
{
    public GameEvent fallEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bound")
        {
            fallEvent.Raise();
        }
    }
}
