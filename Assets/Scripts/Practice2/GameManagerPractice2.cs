using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManagerPractice2 : MonoBehaviour
{
    #region Fields

    [SerializeField] private Transform _spawnPoint;

    private HashSet<int> _visitedPlatforms;
    private Rigidbody _playerRigidBody;


    public int recordScore;
    public static GameManagerPractice2 gameManagerInstance;
    public int deathScore;

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

        recordScore = 0;
        _visitedPlatforms = new HashSet<int>();
    }

    #endregion

    #region Methods

    public void AddDeathPoint()
    {
        deathScore++;
    }

    public void RespawnPlayer(GameObject player, Rigidbody playerRigidBody)
    {
        player.transform.position = _spawnPoint.position;
        playerRigidBody.velocity = Vector3.zero;
    }

    public void AddVisitedPlatform(int platformId)
    {
        _visitedPlatforms.Add(platformId);
        if (GetVisitedPlatforms() > recordScore)
        {
            recordScore = GetVisitedPlatforms();
        }
    }

    public int GetVisitedPlatforms()
    {
        return _visitedPlatforms.Count;
    }

    public void ResetVisitedPlatforms()
    {
        _visitedPlatforms.Clear();
    }

    #endregion
}