using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneColliderController : MonoBehaviour
{
    #region Unity Callbacks

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManagerPractice2.gameManagerInstance.RespawnPlayer(other.gameObject, other.GetComponent<Rigidbody>());
            GameManagerPractice2.gameManagerInstance.AddDeathPoint();
            GameManagerPractice2.gameManagerInstance.ResetVisitedPlatforms();
        }
    }

    #endregion
}