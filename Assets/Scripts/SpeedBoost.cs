using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    #region Fields

    private Rigidbody playerRigidbody;

    public float speedBoostValue;

    #endregion

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.forward * speedBoostValue);
        }
    }
}