using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisionController : MonoBehaviour
{
    #region Fields

    public bool isGrounded;

    #endregion
    
    #region Unity Callbacks

    private void Awake()
    {
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }

    #endregion
}
