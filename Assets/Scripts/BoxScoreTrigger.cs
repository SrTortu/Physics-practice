using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScoreTrigger : MonoBehaviour
{
    #region Fields

    private bool _hasFallen;
    private Rigidbody _boxRigidBody;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _hasFallen = false;
        _boxRigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player"))
            && !_hasFallen && _boxRigidBody.velocity.magnitude > 1)
        {
            _hasFallen = true;
            GameManager.gameManagerInstance.AddScore();
        }

        print(_boxRigidBody.velocity.magnitude);
    }

    #endregion
}