using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Props", menuName = "Props/Game")]
public class GameAttributes : ScriptableObject, ISerializationCallbackReceiver
{
    private int _lives = 3;

    [NonSerialized]
    public int lives = 3;
    public bool isPlaying = false;
    public bool gameOver = false;

    public void OnBeforeSerialize() { }

    public void OnAfterDeserialize()
    {
        lives = _lives;
    }
}
