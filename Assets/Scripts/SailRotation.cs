using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailRotation : MonoBehaviour
{
    [SerializeField] private Transform _sail;

    private float _progressRotation = 0.5f;

    private Quaternion _leftAngle = Quaternion.Euler(0, -90, 0);
    private Quaternion _rightAngle = Quaternion.Euler(0, 90, 0);

    private void Update()
    {
        if(Input.GetKey(KeyCode.Q))
            _progressRotation -= Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            _progressRotation += Time.deltaTime;

        if(_progressRotation < 0)
            _progressRotation = 0;

        if (_progressRotation > 1)
            _progressRotation = 1;
                
        _sail.localRotation = Quaternion.Lerp(_leftAngle, _rightAngle, _progressRotation);

    }
}
