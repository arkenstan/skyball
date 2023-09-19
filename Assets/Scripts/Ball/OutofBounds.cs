using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutofBounds : MonoBehaviour
{
    public BallManager bm;

    private void Start()
    {
        bm = GetComponent<BallManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bound")
        {
            bm.DidFall();
        }
    }

}
