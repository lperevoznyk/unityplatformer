using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class MainHero : MonoBehaviour
{
    private Vector2 _direction;
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_direction.x * _speed, _rigidbody2D.velocity.y);
    }


    public void SetDirection(Vector2 direction)
    {
        this._direction = direction;
    }

    internal void Fire()
    {
        Debug.Log("Fire!");
    }
}