using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFront : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Update()
    {
        transform.Translate(0, 0, _duration * Time.deltaTime);
    }
}
