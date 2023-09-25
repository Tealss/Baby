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
    public void OnLook(InputValue value)
    {
        Vector2 worldPos = _camera.ScreenToWorldPoint(value.Get<Vector2>());
        Vector2 lookDirection = (worldPos - (Vector2)transform.position).normalized;
        if (lookDirection.magnitude > 0.9f)
            CallLookEvent(lookDirection);
    }
    public void OnShoot(InputValue value)
    {
        

    }
}
