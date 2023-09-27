using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem.XR;

public class Monster : MonoBehaviour
{
    public float startingHP = 100; // 몬스터의 초기 체력
    public float speed = 3;
    public float AD = 10.0f;

    private float currentHP; // 현재 체력

    void Start()
    {
        currentHP = startingHP;
    }

    void Update()
    {
        // 몬스터의 체력이 0 이하로 떨어지면 파괴
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    // 다른 오브젝트(총알 등)이 몬스터와 충돌할 때 호출되는 메서드
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet")) // 충돌한 오브젝트가 총알인 경우
        {
            // 총알의 데미지를 몬스터의 체력에서 빼기
            Bullet bullet = other.GetComponent<Bullet>();
            if (bullet != null)
            {
                currentHP -= bullet.damage;
            }

            // 총알 파괴
            Destroy(other.gameObject);
        }
    }
}