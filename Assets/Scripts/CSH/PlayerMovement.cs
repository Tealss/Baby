using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    protected CharacterController Controller;
    protected Rigidbody2D Rigidbody2D;
    protected SpriteRenderer SpriteRenderer;
    protected Animator Animator;
    protected Vector2 MovementDirection = Vector2.zero;


    protected virtual void Start()
    {
        Controller = GetComponent<CharacterController>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Animator = GetComponentInChildren<Animator>();
        Controller.OnMoveEvent += Move;
    }
    protected virtual void FixedUpdate()
    {
        ApplyMovement(MovementDirection);
    }

    private void Move(Vector2 direction)
    {
        MovementDirection = direction;
        if(direction.x < 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if(direction.x > 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (direction.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (direction.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

    private void ApplyMovement(Vector2 direction)
    {
        //direction = direction * 5;

        //Rigidbody2D.velocity = direction;
        Rigidbody2D.velocity = TopDownCharacter.Instance.Speed * direction;
    }

}
