using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    protected CharacterController Controller;
    protected Rigidbody2D Rigidbody2D;
<<<<<<< HEAD
    protected SpriteRenderer SpriteRenderer;
    protected Animator Animator;
    protected Vector2 MovementDirection = Vector2.zero;


    protected virtual void Start()
    {
        Controller = GetComponent<CharacterController>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Animator = GetComponentInChildren<Animator>();
=======

    protected Vector2 MovementDirection = Vector2.zero;


    [Header("Body")]
    public Transform Body;
    Animator BodyAnimator;
    SpriteRenderer BodySpriteRenderer;



    protected virtual void Start()
    {  
        Controller = GetComponent<CharacterController>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        BodySpriteRenderer = Body.GetComponent<SpriteRenderer>();
        BodyAnimator = Body.GetComponent<Animator>();
>>>>>>> SJM_New2
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
<<<<<<< HEAD
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if(direction.x > 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
=======
            
            BodySpriteRenderer.flipX = true;
            BodyAnimator.SetBool("isRun_R", true);
            
        }
        else if(direction.x > 0) 
        {
            BodyAnimator.SetBool("isRun_R", true);
            BodySpriteRenderer.flipX = false;
>>>>>>> SJM_New2
        }
        if (direction.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (direction.y > 0)
<<<<<<< HEAD
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
=======
        {       
            BodyAnimator.SetBool("isRun_UP", true);           
        }
        else
        {
            BodyAnimator.SetBool("isRun_UP", false);
            BodyAnimator.SetBool("isRun_R", false);
        }
        
>>>>>>> SJM_New2

    }

    private void ApplyMovement(Vector2 direction)
    {
        //direction = direction * 5;

        //Rigidbody2D.velocity = direction;
        Rigidbody2D.velocity = TopDownCharacter.Instance.Speed * direction;
    }

}
