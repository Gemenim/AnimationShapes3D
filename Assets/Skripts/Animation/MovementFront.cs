using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFront : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private bool _isMovingX;
    [SerializeField] private bool _isMovingY;
    [SerializeField] private bool _isMovingZ;

    void Update()
    {
        if (_isMovingX)
            transform.Translate(_duration * Time.deltaTime, 0, 0);
        else if (_isMovingY)
            transform.Translate(0, _duration * Time.deltaTime, 0);
        else if (_isMovingZ)
            transform.Translate(0, 0, _duration * Time.deltaTime);
    }
}
