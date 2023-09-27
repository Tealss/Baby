using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacter : MonoBehaviour
{
    private static TopDownCharacter _instance = null;

<<<<<<< Updated upstream
    public int CurrentHP = 100;
    public int MaxHP = 100;
    public float Speed = 5f;
    public float attackPower = 5;
    public bool m_die = false;//À¯´Ö »ç¸Á ¿©ºÎ
=======
    private int maxHp = 10;
    //public int MaxHp//ÇÁ·ÎÆÛÆ¼ »ç¿ë ¿¹Á¤
    //{
    //    get { return maxHp; }
    //    private set { maxHp = Mathf.Clamp(value, 0, 10); }
    //}

    private int currentHp = 3;
    //public int CurrentHp
    //{
    //    get { return currentHp; }
    //    private set { currentHp = Mathf.Clamp(value, 0, maxHp); }
    //}

    private float Speed = 5f;
    private float attackPower = 5;
    private bool m_die = false;//À¯´Ö »ç¸Á ¿©ºÎ
>>>>>>> Stashed changes

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

        currentHp = Mathf.Clamp(currentHp - damage, 0, maxHp);

        if(currentHp == 0)
        {
            m_die = true;
        }
    }

    public void TakeHeal(int heal)
    {
        currentHp = Mathf.Clamp(currentHp + heal, 0, maxHp);
    }

    public void UpAttackPower(float power) 
    {
        attackPower += power;
    }
    public void UpSpeed(float speed) 
    {
        Speed += speed;
    }
<<<<<<< Updated upstream
=======
    public float GetSpeed()
    {
        return Speed;
    }
    public int GetMaxHp()
    {
        return maxHp;
    }
    public int GetCurrentHp()
    {
        return currentHp;
    }
>>>>>>> Stashed changes

}
