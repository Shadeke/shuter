using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Graviyty = 9.8f;
    public float JumpForce;
    public float Speed;
    private float _fallSpead = 0;
    private CharacterController _CC;
    private Vector3 _vector;

    // Start is called before the first frame update
    void Start()
    {
        _CC = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _CC.isGrounded)
        {
            _fallSpead = -JumpForce;
        }
        Debug.Log(_CC.isGrounded);
        //бег
        _vector = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            _vector += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _vector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _vector += transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _vector -= transform.right;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _fallSpead += Graviyty * Time.fixedDeltaTime;

        if (_CC.isGrounded)
        {
            _fallSpead = 0;
        }
        _CC.Move(Vector3.down * _fallSpead * Time.fixedDeltaTime);


        // бег
        _CC.Move(_vector * Speed * Time.fixedDeltaTime);
    }
}   
