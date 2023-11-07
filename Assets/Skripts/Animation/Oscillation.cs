using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    [SerializeField] private float _maxDistance;
    [SerializeField] private float _minDistance;
    [SerializeField] private float _speed;

    private float _distance;

    private void Update()
    {
        _distance += _speed * Time.deltaTime;
        CheckDistance();
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }

    private void CheckDistance()
    {
        if (_distance >= _maxDistance)
            _speed = -_speed;
        else if (_distance <= -_minDistance)
            _speed = -_speed;
    }
}
