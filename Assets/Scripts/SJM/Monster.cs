using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem.XR;

public class Monster : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _anim;
    private Rigidbody2D _target;
    public Gameobject Player1;

    public Slider mySlider;

<<<<<<< HEAD
    private int _MaxHp;
=======
    public static float HP;
    public static float speed;
    public static float AD;
    Rigidbody2D rigid;
>>>>>>> SJM_New2

    private int _Hp;
    private float _Speed;
    private bool _IsHit = false;
    private bool _IsDelay = false;

    public void Init(int hp, float speed)
    {
<<<<<<< HEAD
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        //_target = Gameobject;  //�÷��̾� �߰�
        _MaxHp = hp;
        _Hp = hp;
        _Speed = speed;
        mySlider.value = _Hp / _MaxHp;
        _rigidbody.velocity = Vector2.zero;
=======
        HP = 100;
        rigid = GetComponent<Rigidbody2D>();
        speed = 3;
        AD = 10.0f;
>>>>>>> SJM_New2
    }

    void FixedUpdate()
    {
<<<<<<< HEAD
        if (_IsHit)
        {
            _rigidbody.velocity = (_target.position - _rigidbody.position) * -2;
        }
        else
        {
            _rigidbody.velocity = (_target.position - _rigidbody.position) * _Speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SnowBall")) //�ǰ� ������
        {
            _anim.SetTrigger("Hit");
            _IsHit = true;
            StartCoroutine(Hit());
            _Hp--;
            mySlider.value = (float)_Hp / (float)_MaxHp;
            if (_Hp <= 0)
            {
                gameObject.SetActive(false);
            }
        }

        if (collision.CompareTag("Player")) //�÷��̾ ������ ü���� ��� �ڵ�
        {
            if (!_IsDelay)
            {
                _IsDelay = true;
                //AudioManager.I.PlaySfx(AudioManager.Sfx.Hit);
                //HpController.I.CallHpAdd(-15f);
                StartCoroutine(Delay());
            }

        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        _IsDelay = false;
    }


    IEnumerator Hit()
    {
        yield return new WaitForSeconds(0.1f);
        _IsHit = false;
=======
        // ������ ü���� 0 ���Ϸ� �������� �ı�
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    // �ٸ� ��ũ��Ʈ���� ȣ���Ͽ� ������ ü���� ���ҽ�Ű�� �޼���
    public void TakeDamage(float damage)
    {
        HP -= damage;
>>>>>>> SJM_New2
    }
}