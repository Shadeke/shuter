 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator Anim;
    public float Graviyty = 9.8f;
    public float JumpForce;
    public float Speed;

    private Vector3 _vector;
    private float _fallSpead = 0;
    private CharacterController _CC;

    // Start is called before the first frame update
    void Start()
    {
        _CC = GetComponent<CharacterController>();
    }

    private void Update()
    {
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

             if (_vector != Vector3.zero)
                {
                    Anim.SetBool("Run", true);
                }
                else 
                {
                    Anim.SetBool("Run", false);
                }
            
        if (Input.GetKeyDown(KeyCode.Space) && _CC.isGrounded)
        {
            _fallSpead = -JumpForce;
            Anim.SetTrigger("Jump 0");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // бег
        _CC.Move(_vector * Speed * Time.fixedDeltaTime);

        _fallSpead += Graviyty * Time.fixedDeltaTime;
        _CC.Move(Vector3.down * _fallSpead * Time.fixedDeltaTime);

        if (_CC.isGrounded)
        {
            _fallSpead = 0;
            Anim.SetBool("Jump", true);
        }


    }
}   
