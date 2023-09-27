using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem.XR;

public class Monster : MonoBehaviour
{
    public float startingHP = 100; // ������ �ʱ� ü��
    public float speed = 3;
    public float AD = 10.0f;

    private float currentHP; // ���� ü��

    void Start()
    {
        currentHP = startingHP;
    }

    void Update()
    {
        // ������ ü���� 0 ���Ϸ� �������� �ı�
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    // �ٸ� ������Ʈ(�Ѿ� ��)�� ���Ϳ� �浹�� �� ȣ��Ǵ� �޼���
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet")) // �浹�� ������Ʈ�� �Ѿ��� ���
        {
            // �Ѿ��� �������� ������ ü�¿��� ����
            Bullet bullet = other.GetComponent<Bullet>();
            if (bullet != null)
            {
                currentHP -= bullet.damage;
            }

            // �Ѿ� �ı�
            Destroy(other.gameObject);
        }
    }
}