using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = 10f;
    public Rigidbody2D Rigidbody;
    public void DestoryBulletInvoke()
    {
        Invoke(nameof(DestroyBullet), 2f);
    }
    private void DestroyBullet()
    {
        ObjectPool.Instance.ReturnObj(this);
    }
    public void Move(Vector2 Direction)
    {
        //transform.up = Direction;
        Rigidbody.velocity = Direction * speed;
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
