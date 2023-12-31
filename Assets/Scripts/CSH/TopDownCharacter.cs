using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacter : MonoBehaviour
{
    private static TopDownCharacter _instance = null;

    public int CurrentHP = 100;
    public int MaxHP = 100;
    public float Speed = 5f;
    public float attackPower = 5;
    public bool m_die = false;//���� ��� ����

    // Start is called before the first frame update
    public static TopDownCharacter Instance
    {
        get
        {
            if(null == _instance)
            {
                return null;
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(null == _instance) 
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject );
        }
    }

    public void TakeDamage(int damage)
    {
        if (m_die)
        {
            return;
        }

        CurrentHP = Mathf.Clamp(CurrentHP - damage, 0, MaxHP);

        if(CurrentHP == 0)
        {
            m_die = true;
        }
    }

    public void TakeHeal(int heal)
    {
        CurrentHP = Mathf.Clamp(CurrentHP + heal, 0, MaxHP);
    }

    public void UpAttackPower(float power) 
    {
        attackPower += power;
    }
    public void UpSpeed(float speed) 
    {
        Speed += speed;
    }

}
