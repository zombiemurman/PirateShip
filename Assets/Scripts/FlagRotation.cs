using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagRotation : MonoBehaviour
{
    [SerializeField] private Transform _wind;
    private float _rotateSpeed = 50;

    private void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _wind.rotation, _rotateSpeed);
    }
}
