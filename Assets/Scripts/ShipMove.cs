using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    [SerializeField] private Transform _ship;
    [SerializeField] private Transform _sail;
    [SerializeField] private Transform _wind;
    [SerializeField] private float _speed;

    private float _currnetSpeed = 0;

    [SerializeField] private CharacterController _characterController;

    private void Update()
    {
        float dotSailWind = Vector3.Dot(_sail.forward.normalized, _wind.forward.normalized);
        float dotSaiShip = Vector3.Dot(_sail.forward.normalized, _ship.forward.normalized);

        _currnetSpeed = _speed * dotSailWind * dotSaiShip;

        if(_currnetSpeed < 0)
            _currnetSpeed = 0;

    }

    private void FixedUpdate()
    {
        Vector3 _movement = (transform.forward * _speed).normalized;

        _characterController.Move(_movement * _currnetSpeed * Time.fixedDeltaTime);
    }
}
