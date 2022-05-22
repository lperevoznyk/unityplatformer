using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float aboveYPosition;
    [SerializeField] private float belowYPosition;
    private float _direction = 1;

    void Update()
    {
        if (transform.position.y >= aboveYPosition)
        {
            _direction = -1;
        }
        else if (transform.position.y <= belowYPosition)
        {
            _direction = 1;
        }
        var deltaPosition = _direction * _speed * Time.deltaTime;
            var nextYPosition = transform.position.y + deltaPosition;
            transform.position = new Vector3(transform.position.x, nextYPosition, transform.position.z);

    }
}