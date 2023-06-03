using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCollision : MonoBehaviour
{

  BallController bController;

  // Start is called before the first frame update
  void Start()
  {

    bController = GetComponent<BallController>();

  }

  // Update is called once per frame
  void Update()
  {



  }

  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Track")
    {
      bController.canJump = true;
    }
  }

  /// <summary>
  /// OnCollisionExit is called when this collider/rigidbody has
  /// stopped touching another rigidbody/collider.
  /// </summary>
  /// <param name="other">The Collision data associated with this collision.</param>
  void OnCollisionExit(Collision other)
  {
    bController.canJump = false;
  }

}
