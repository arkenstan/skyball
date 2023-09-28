using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public TrackAttributes trackAttrs;
    public GameAttributes gameProps;

    public GameEvent gameOverEvent,
        resetEvent;

    [SerializeField]
    public GameObject startPlatform;

    private readonly float deltaY = 10f;

    void Start()
    {
        GetInitialPosition();
    }

    public void GetInitialPosition()
    {
        Vector3 platformPosition = startPlatform.transform.position;
        Vector3 resetPosition =
            new(platformPosition.x, platformPosition.y + deltaY, platformPosition.z);
        trackAttrs.resetPosition = resetPosition;
        trackAttrs.initialPosition = platformPosition;
    }

    public void FallHandler()
    {
        --gameProps.lives;
        if (gameProps.lives <= 0)
        {
            gameOverEvent.Raise();
        }
        else
        {
            resetEvent.Raise();
        }
    }

    public void FinishHandler()
    {
        resetEvent.Raise();
    }

    public void GameOverHandler()
    {
        resetEvent.Raise();
    }
}
