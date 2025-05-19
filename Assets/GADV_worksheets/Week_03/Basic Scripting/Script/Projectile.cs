using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    private float speed = 1f;
    public Projectile(float Speed)
    {
        speed = Speed;
    }
    public void AutoFire()
    {
        speed = 100f;
        Debug.Log($"Speed set to {speed}, Auto Fire");
    }
    public void Fire()
    {
        if (speed > 0f)
        {
            Debug.Log($"Firing Projectile at {speed}");
        }
        else if (speed == 0f)
        {
            AutoFire();
        }
        else
        {
            Debug.Log("Cannot fire: Speed too low");
        }
    }
}