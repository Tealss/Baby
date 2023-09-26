using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    protected CharacterController Controller;
    protected Rigidbody2D Rigidbody2D;
    protected SpriteRenderer HeadSpriteRenderer;
    protected SpriteRenderer BodySpriteRenderer;
    protected Animator HeadAnimator;
    protected Animator BodyAnimator;
    protected Vector2 MovementDirection = Vector2.zero;
    protected Transform Head;
    protected Transform Body;


    protected virtual void Start()
    {
        Head = transform.GetChild(0);
        Body = transform.GetChild(1);  
        Controller = GetComponent<CharacterController>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        HeadSpriteRenderer = Head.GetComponent<SpriteRenderer>();
        BodySpriteRenderer = Body.GetComponent<SpriteRenderer>();
        HeadAnimator = Head.GetComponent<Animator>();
        BodyAnimator = Body.GetComponent<Animator>();
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
            HeadSpriteRenderer.flipX = true;
            BodySpriteRenderer.flipX = true;
            HeadAnimator.SetBool("isRun_HR", true);
            BodyAnimator.SetBool("isRun_R", true);
            
        }
        else if(direction.x > 0) 
        {
            HeadAnimator.SetBool("isRun_HR", true);
            BodyAnimator.SetBool("isRun_R", true);
            HeadSpriteRenderer.flipX = false;
            BodySpriteRenderer.flipX = false;
        }
        else if (direction.y < 0)
        {
            BodyAnimator.SetBool("isRun_UP", true);
            //transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (direction.y > 0)
        {
            HeadAnimator.SetBool("isRun_HU", true);
            BodyAnimator.SetBool("isRun_UP", true);
            
        }
        else
        {
            HeadAnimator.SetBool("isRun_HR", false);
            HeadAnimator.SetBool("isRun_HU", false);
            BodyAnimator.SetBool("isRun_UP", false);
            BodyAnimator.SetBool("isRun_R", false);
        }
        

    }

    private void ApplyMovement(Vector2 direction)
    {
        //direction = direction * 5;

        //Rigidbody2D.velocity = direction;
        Rigidbody2D.velocity = TopDownCharacter.Instance.GetSpeed() * direction;
    }

}
