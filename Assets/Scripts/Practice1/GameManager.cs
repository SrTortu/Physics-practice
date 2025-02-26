using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Fields

    public static GameManager gameManagerInstance;
    public int score;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        if (gameManagerInstance == null)
        {
            gameManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    #region Methods

    public void AddScore()
    {
        score++;
    }

    #endregion
}