﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float Value = 100;
    void Update()
    {
        if (Value <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void DealDamage(float damage)
    {
        Value -= damage;
        if (Value <= 0)
        {
            Destroy(gameObject);
        }
    }

}
