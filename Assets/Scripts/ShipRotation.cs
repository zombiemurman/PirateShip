using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    [SerializeField] private Transform _ship;
    [SerializeField] private float _rotationSpeed = 50;

    private float _progressRotation;

    private void Update()
    {

        if (Input.GetKey(KeyCode.A))
            _progressRotation -= Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            _progressRotation += Time.deltaTime;

        Quaternion target = Quaternion.Euler(0f, _progressRotation * _rotationSpeed, 0f);
        _ship.localRotation = target;

    }
}
