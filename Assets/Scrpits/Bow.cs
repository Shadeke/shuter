using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Arrow Arrow;
    public float KImpulse;
    public float ShotImpulse = 0f;

    private Rigidbody _rigidbody;

    private void Start()
    {
      _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        while (Input.GetMouseButtonDown(0)&& ShotImpulse < 90)
        {
            InvokeRepeating("ChargeAccumulation", 0, 3);
        }

    }
    void ChargeAccumulation()
    {
        // Это вспомогательная штука
            ShotImpulse = ShotImpulse + 30;
    }

}
