using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHeal : DropItems
{
    [SerializeField] int healValue = 10;
    //private HealthSystem _healthSystem;

    protected override void OnPickedUp(GameObject receiver)
    {
        //_healthSystem = receiver.GetComponent<HealthSystem>();
        //_healthSystem.ChangeHealth(healValue);
    }
}
