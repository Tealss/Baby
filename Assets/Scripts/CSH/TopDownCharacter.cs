using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacter : MonoBehaviour
{
    private static TopDownCharacter _instance = null;

    public int CurrentHP = 100;
    public int MaxHP = 100;
    public float Speed = 5;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
