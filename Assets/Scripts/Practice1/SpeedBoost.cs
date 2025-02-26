using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    #region Fields

    private Rigidbody _playerRigidbody;

    public float speedBoostValue;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _playerRigidbody.AddForce(Vector3.forward * speedBoostValue);
        }
    }

    #endregion
}