using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

  public float speed = 10f;
  public float xForce = 10.0f;
  public float zForce = 10.0f;
  public float yForce = 500.0f;
  public int resetLevel = -10;
  public bool canJump = false;
  public bool canForce = false;

  private GameObject startPlatform;

  Rigidbody rb;
  Vector3 initPosition;

  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    startPlatform = GameObject.FindGameObjectWithTag("start");
    Vector3 platformPosition = startPlatform.transform.position;
    initPosition = new(platformPosition.x, platformPosition.y + 10f, platformPosition.z);
    transform.position = initPosition;
  }

  // Update is called once per frame
  void Update()
  {
    movementControl();
    checkForReset();
  }

  private void checkForReset()
  {
    if (transform.position.y < resetLevel)
    {
      transform.position = initPosition;
      rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;

    }
  }

  private void movementControl()
  {
    //this is for x axis' movement

    float x = 0.0f;
    if (Input.GetKey(KeyCode.A))
    {
      x = x - xForce;
    }

    if (Input.GetKey(KeyCode.D))
    {
      x = x + xForce;
    }

    //this is for z axis' movement

    float z = 0.0f;
    if (Input.GetKey(KeyCode.S))
    {
      z = z - zForce;
    }

    if (Input.GetKey(KeyCode.W))
    {
      z = z + zForce;
    }
    //this is for z axis' movement

    float y = 0.0f;
    if (Input.GetKeyDown(KeyCode.Space) && canJump)
    {
      y = yForce;
    }

    if (canForce)
    {
      rb.AddForce(x, y, z);
    }


  }



}
