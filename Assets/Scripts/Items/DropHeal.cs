using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHeal : DropItems
{
    [SerializeField] Items _item;

    protected override void OnPickedUp(GameObject receiver)
    {
        TopDownCharacter.Instance.CurrentHP += _item.healthFigures;

        TopDownCharacter.Instance.CurrentHP = (TopDownCharacter.Instance.CurrentHP > TopDownCharacter.Instance.MaxHP) ? TopDownCharacter.Instance.MaxHP : TopDownCharacter.Instance.CurrentHP;
    }
}
