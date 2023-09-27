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
    public void MoveUp()
    {
        Rigidbody.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
    }
    public void MoveDown()
    {
        Rigidbody.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
    }
    public void MoveLeft()
    {
        Rigidbody.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
    }
    public void MoveRight()
    {
        Rigidbody.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
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
