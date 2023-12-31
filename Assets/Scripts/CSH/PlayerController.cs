using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharacterController
{
    private Camera _camera;

    protected override void Start()
    {
        base.Start();
        _camera = Camera.main;
    }
    public void OnMove(InputValue value)
    {
        CallMoveEvent(value.Get<Vector2>());
    }

    public void OnShoot(InputValue value)
    {
        IsShooting = value.isPressed;

    }
}
