using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class PlatformMobile : MonoBehaviour
{
    #region Enum

    public enum MoveDirections
    {
        Right,
        Left
    }

    #endregion
    #region Fields

    private const float MOVE_DISTANCE = 3f;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private MoveDirections _moveDirection;

    private Rigidbody _platformRigidbody;
    private Vector3 _pointLeft;
    private Vector3 _pointRight;
    private Vector3 _targetPoint;

    #endregion

    #region UnityCallbacks

    private void Awake()
    {
        _platformRigidbody = GetComponent<Rigidbody>();
        _pointLeft = new Vector3(this.transform.position.x - MOVE_DISTANCE, this.transform.position.y,
            this.transform.position.z);
        _pointRight = new Vector3(this.transform.position.x + MOVE_DISTANCE, this.transform.position.y,
            this.transform.position.z);
        _targetPoint = _moveDirection == MoveDirections.Right ? _pointRight : _pointLeft;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, _moveSpeed ); 
        if (Vector3.Distance(transform.position, _targetPoint) < 0.1f)
        {
            _targetPoint = _targetPoint == _pointRight ? _pointLeft : _pointRight;
        }
    }

    #endregion
}