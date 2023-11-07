using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SizeFluctuation : MonoBehaviour
{
    [SerializeField] private Vector3 _targetSize;
    [SerializeField] private float _speedChanges;


    private float _sizeX;
    private float _sizeY;
    private float _sizeZ;
    private float _scaleX;
    private float _scaleY;
    private float _scaleZ;

    private void Start()
    {
        _sizeX = transform.localScale.x;
        _sizeY = transform.localScale.y;
        _sizeZ = transform.localScale.z;
        _scaleX = transform.localScale.x;
        _scaleY = transform.localScale.y;
        _scaleZ = transform.localScale.z;
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
        else if (_scaleX < _sizeX || _scaleY < _sizeY || _scaleZ < _sizeZ)
            _speedChanges = -_speedChanges;
    }
}
