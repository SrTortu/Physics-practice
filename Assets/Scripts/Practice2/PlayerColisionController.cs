using System;
using UnityEngine;

public class PlayerColisionController : MonoBehaviour
{
    #region Fields

    private Vector3 _originalGlobalScale;
    private GameObject _pivotParent;

    public bool isGrounded;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        isGrounded = false;


        _pivotParent = new GameObject("PlayerPivot");
        _pivotParent.transform.SetParent(null);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Platform") || other.gameObject.CompareTag("Ground"))
        {
            if (other.gameObject.CompareTag("Platform"))
            {
                _pivotParent.transform.SetParent(other.transform, true);
                _pivotParent.transform.position = transform.position;
                transform.SetParent(_pivotParent.transform, true);
                GameManagerPractice2.gameManagerInstance.AddVisitedPlatform(other.gameObject.GetInstanceID());
            }

            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Platform") || other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            transform.SetParent(null);
            _pivotParent.transform.SetParent(null);
        }
    }

    #endregion
}