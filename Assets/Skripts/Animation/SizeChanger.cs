using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SizeFluctuation : MonoBehaviour
{
    [SerializeField] private Vector3 _targetSize;
    [SerializeField] private float _speedChanges;

    private float _startSizeX;
    private float _startSizeY;
    private float _startSizeZ;
    private float _scaleX;
    private float _scaleY;
    private float _scaleZ;

    private void Start()
    {
        _startSizeX = transform.localScale.x;
        _startSizeY = transform.localScale.y;
        _startSizeZ = transform.localScale.z;
        _scaleX = _startSizeX;
        _scaleY = _startSizeY;
        _scaleZ = _startSizeZ;
    }

    private void Update()
    {
        CheckSize();
        _scaleX += Time.deltaTime * _speedChanges;
        _scaleY += Time.deltaTime * _speedChanges;
        _scaleZ += Time.deltaTime * _speedChanges;
        transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
    }

    private void CheckSize()
    {
        if (_scaleX > _targetSize.x || _scaleY > _targetSize.y || _scaleZ > _targetSize.z)
            _speedChanges = -_speedChanges;
        else if (_scaleX < _startSizeX || _scaleY < _startSizeY || _scaleZ < _startSizeZ)
            _speedChanges = -_speedChanges;
    }
}
