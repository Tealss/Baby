using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public player player;
    
    public List<Gameobject> rewards = new List<Gameobject>();

    void Awake()
    {
        instance = this;
       
    }

    void Start()
    {
        rewards.Clear();
    }

    void Update()
    {

    }
    void CreateReward()
    {

    }
}
