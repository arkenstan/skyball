using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

  public int lives = 3;

  private int currentLives = 0;

  [SerializeField] public GameObject player, startPlatform, endPlatform;

  private readonly float deltaY = 10f;

  [HideInInspector] public UnityEvent onFinish = new UnityEvent();
  [HideInInspector] public UnityEvent onGameOver = new UnityEvent();
  [HideInInspector] public UnityEvent reset = new UnityEvent();

  void Start()
  {
    currentLives = lives;
    SetupEvents();
  }


  void SetupEvents()
  {
    onFinish.AddListener(FinishHandler);
    onGameOver.AddListener(GameOverHandler);
  }


  public Vector3 GetInitialPosition()
  {
    Vector3 platformPosition = startPlatform.transform.position;
    Vector3 resetPosition = new(platformPosition.x, platformPosition.y + deltaY, platformPosition.z);
    return resetPosition;
  }

  public void FallHandler()
  {
    --currentLives;
    if (currentLives <= 0)
    {
      onGameOver.Invoke();
    }
    else
    {
      reset.Invoke();
    }
  }

  void FinishHandler() { }

  void GameOverHandler() { }
}
