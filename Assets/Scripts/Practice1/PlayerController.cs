using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    private bool _shouldJump;
    private Jump _jump;
    private PlayerColisionController _playerCollisionController;
    private Rigidbody _playerRigidbody;
    private Vector3 _movementVector;

    public float playerSpeed;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        TryGetComponent<PlayerColisionController>(out _playerCollisionController);
        TryGetComponent<Jump>(out _jump);
        _shouldJump = false;
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        _movementVector = new Vector3(moveX, 0, moveZ).normalized;
        
        if (_jump != null && _playerCollisionController != null)
        {
            if (Input.GetKeyDown(KeyCode.Space) && _playerCollisionController.isGrounded)
            {
                _shouldJump = true;
            }
        }
    }

    private void FixedUpdate()
    {
        _playerRigidbody.AddForce(_movementVector * playerSpeed, ForceMode.Force);

        if (_shouldJump)
        {
            _jump.makeJump();
            _shouldJump = false;
        }
    }

    #endregion
}