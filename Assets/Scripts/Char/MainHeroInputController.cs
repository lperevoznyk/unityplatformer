using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHeroInputController : MonoBehaviour
{

    private MainHero _mainHero;

    private void Awake()
    {
        _mainHero = GetComponent<MainHero>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _mainHero.SetDirection(-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _mainHero.SetDirection(1);
        }
        else
        {
            _mainHero.SetDirection(0);
        }
    }
}
