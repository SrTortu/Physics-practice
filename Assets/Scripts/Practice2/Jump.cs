using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    #region Fields

    [SerializeField] private float _jumpForce;

    private Rigidbody _playerRigidBody;

    #endregion

    private void Awake()
    {
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    public void makeJump()
    {
        _playerRigidBody.AddForce(Vector3.up * _jumpForce);
    }
}