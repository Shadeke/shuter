using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Graviyty = 9.8f;
    public float JumpForce;
    private float _fallSpead = 0;
    private CharacterController _CC;
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

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _fallSpead += Graviyty * Time.fixedDeltaTime;
        _CC.Move(Vector3.down * _fallSpead * Time.fixedDeltaTime);
    }
}
