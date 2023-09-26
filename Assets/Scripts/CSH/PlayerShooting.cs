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

    public void Shoot(Vector2 direction)
    {
        if (direction.x != 0 || direction.y != 0)//Ű���� ���� Ÿ�ֿ̹� 0�� �Էµ� �������� �𸣰���
        {
            Bullet bullet = ObjectPool.Instance.GetObject();
            bullet.transform.position = transform.position;
            bullet.Move(direction);
            bullet.DestoryBulletInvoke();
        }
    }
}
