using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = 10f;
    float fallingDistance = -1f;
    Rigidbody2D Rigidbody;
    Animator animator;
    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void DestoryBulletInvoke()
    {
        Rigidbody.gravityScale = 2.5f;
        animator.Play("Destroy");
        Invoke(nameof(DestroyBullet), 0.2f);
    }
    private void DestroyBullet()
    {
        Rigidbody.gravityScale = 0f;
        Rigidbody.velocity = Vector2.zero;
        ObjectPool.Instance.ReturnObj(this);
    }
    public void Move(Vector2 Direction)
    {
        //transform.up = Direction;
        //if (Direction.x > 0)
        //    Rigidbody.AddForce(Vector2.right*10, ForceMode2D.Impulse);
        //else if (Direction.x < 0)
        //    Rigidbody.AddForce(Vector2.left*10, ForceMode2D.Impulse);
        //else if (Direction.y > 0)
        //    Rigidbody.AddForce(Vector2.up*10, ForceMode2D.Impulse);
        //else if (Direction.y < 0)
        //    Rigidbody.AddForce(Vector2.down*10, ForceMode2D.Impulse);
        Rigidbody.velocity = Direction * speed;
        //transform.Translate(0, fallingDistance * Time.deltaTime, 0, Space.World);
    }


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            DestroyBullet();
        }
        else if (other.tag == "Enemy" || other.tag == "Boss")
        {
            DestroyBullet();
        }
        else if (other.tag == "Boundary")
        {
            DestroyBullet();
        }
    }
}
