using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCollision : MonoBehaviour
{

  public BallManager bm;
  void Start()
  {
    bm = GetComponent<BallManager>();
  }
  void SetJump(bool val)
  {
    bm.canJump = val;
  }
  void SetMove(bool val)
  {
    bm.CanMove = val;
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
      bm.DidFinish();
    }
  }

  void OnCollisionExit(Collision other) => SetJump(false);

}
