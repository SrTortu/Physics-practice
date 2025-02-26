using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    private Rigidbody _playerRigidbody;
    private Vector3 _movementVector;

    public float playerSpeed;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        _movementVector = new Vector3(moveX, 0, moveZ).normalized;
    }   

    private void FixedUpdate()
    {
        _playerRigidbody.AddForce(_movementVector * playerSpeed,ForceMode.Force);
    }

    #endregion
}