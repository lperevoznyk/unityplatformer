using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHero : MonoBehaviour
{
    private float _direction;
    [SerializeField] private float _speed;

    public void SetDirection(float direction)
    {
        this._direction = direction;
    }

    void Update()
    {
        var deltaPosition = _direction * _speed * Time.deltaTime;
        var nextXPosition = transform.position.x + deltaPosition;
        transform.position = new Vector3(nextXPosition, transform.position.y, transform.position.z);
    }

    internal void Fire()
    {
        Debug.Log("Fire!");
    }
}