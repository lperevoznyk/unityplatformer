using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainHeroInputController : MonoBehaviour
{
    [SerializeField] private MainHero _mainHero;

    public void OnHorizontal(InputAction.CallbackContext context)
    {
        _mainHero.SetDirection(context.ReadValue<Vector2>());
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            _mainHero.Fire();
        }
    }
}