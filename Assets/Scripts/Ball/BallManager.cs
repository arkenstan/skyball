using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallManager : MonoBehaviour
{

  public GameObject gmObj;
  private GameManager gm;
  public bool canJump = true;
  public bool canMoveX = false;
  public bool canMoveZ = false;
  public float resetLevel = -10f;
  public Rigidbody rb;

  public Vector3 initialPosition = Vector3.zero;

  public bool CanMove
  {
    get { return canMoveX && canMoveZ; }
    set { canMoveX = value; canMoveZ = value; }
  }


  private void Start()
  {
    gm = gmObj.GetComponent<GameManager>();
    rb = GetComponent<Rigidbody>();
    SetInitialPosition();
    SetupEventHandlers();
  }


  private void SetupEventHandlers()
  {
    gm.reset.AddListener(ResetPosition);
    gm.onGameOver.AddListener(GameOverHandler);
  }

  void SetInitialPosition()
  {
    initialPosition = gm.GetInitialPosition();
  }

  void ResetPosition()
  {
    transform.position = initialPosition;
    rb.velocity = Vector3.zero;
  }

  private void GameOverHandler()
  {
    bool val = false;
    canJump = val;
    CanMove = val;
  }
  public void DidFall()
  {
    gm.FallHandler();
  }
  public void DidFinish()
  {
    gm.onFinish.Invoke();
  }
}
