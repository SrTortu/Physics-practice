using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManagerPractice2 : MonoBehaviour
{
    #region Fields

    [SerializeField] private Transform _spawnPoint;
    private Rigidbody _playerRigidBody;

    public static GameManagerPractice2 gameManagerInstance;
    public int deathPointsScore;

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

    public void AddDeathPoint()
    {
        deathPointsScore++;
    }

    public void RespawnPlayer(GameObject player, Rigidbody playerRigidBody)
    {
        player.transform.position = _spawnPoint.position;
        playerRigidBody.velocity = Vector3.zero;
    }

    #endregion
}