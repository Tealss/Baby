using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private CharacterController _controller;

<<<<<<< HEAD
=======
    [Header("Head")]
    public Transform Head;
    Animator HeadAnimator;


>>>>>>> SJM_New2
    private void Awake()
    {
        HeadAnimator = Head.GetComponent<Animator>();
        _controller = GetComponent<CharacterController>(); 
    }
    private void Start()
    {
        _controller.OnShootEvent += Shoot;
    }
<<<<<<< HEAD
    public void Shoot()
    {
        Bullet bullet = ObjectPool.Instance.GetObject();
        bullet.transform.position = transform.position;
        bullet.Move(transform.up);
        bullet.DestoryBulletInvoke();
=======

    public void Shoot()
    {

        Bullet bullet = ObjectPool.Instance.GetObject();
        bullet.transform.position = transform.position;
        if(Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            HeadAnimator.Play("HeadUp");
            bullet.MoveUp();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            HeadAnimator.Play("HeadDown");
            bullet.MoveDown();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            HeadAnimator.Play("HeadLeft");
            bullet.MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            HeadAnimator.Play("HeadRight");
            bullet.MoveRight();
        }

        bullet.Invoke("DestoryBulletInvoke",0.45f);

>>>>>>> SJM_New2
    }
}
