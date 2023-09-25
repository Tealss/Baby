using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRatation : MonoBehaviour
{
    private CharacterController _controller;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _controller.OnLookEvent += Look;
    }
    public void Look(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        if(rotz > 90)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }


}
