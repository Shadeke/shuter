using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Arrow Arrow;
    public float KImpulse;

    private float _impulse = 0;
    private Rigidbody _rigidbody;

    private void Start()
    {
      _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        while(Input.GetMouseButtonDown(0)&& _impulse < 1000)
        {
            _impulse = _impulse + 10;  
        }
        if(Input.GetMouseButtonUp(0) && _impulse > 0)
        {
            Instantiate(Arrow, transform.position, transform.rotation);
           
            _impulse = 0;
        }
    }
}
