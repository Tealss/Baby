using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>(); 
    }
    private void Start()
    {
        _controller.OnShootEvent += Shoot;
    }
    public void Shoot()
    {
        Bullet bullet = ObjectPool.Instance.GetObject();
        bullet.transform.position = transform.position;
        bullet.Move(transform.up);
        bullet.DestoryBulletInvoke();
    }
}
