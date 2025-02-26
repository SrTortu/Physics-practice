using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    private Rigidbody playerRigidbody;
    private Vector3 movementVector;

    public float playerSpeed;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        movementVector = new Vector3(moveX, 0, moveZ).normalized;
    }   

    private void FixedUpdate()
    {
        playerRigidbody.AddForce(movementVector * playerSpeed,ForceMode.Force);
    }

    #endregion
}