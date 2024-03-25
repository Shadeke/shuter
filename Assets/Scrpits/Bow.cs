using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bow : MonoBehaviour
{
    public Arrow Arrow;
    public float KImpulse;
    public Transform SpawnPoint;
    public float QuantityArrow = 5;
    public float MaxImpulse = 12;
    public float VImpulse = 4;

    private float _shotImpulse = 0f;
   
    private Rigidbody _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) )
        {
            InvokeRepeating(nameof(ChargeAccumulation), 0, 1);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0) && _shotImpulse > 0 && QuantityArrow > 0)
        {
            Shot();
           
        }
    }
    void ChargeAccumulation()
    {
      
        _shotImpulse = _shotImpulse + VImpulse;
       if (_shotImpulse > MaxImpulse)
        {
            _shotImpulse = MaxImpulse;
        }
        Debug.Log(_shotImpulse);
    }
    public void Shot()
    {
        Arrow arrow = Instantiate(Arrow,SpawnPoint.position, SpawnPoint.rotation);
        arrow.transform.position = SpawnPoint.position;
        arrow.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward * _shotImpulse, ForceMode.Impulse);
        QuantityArrow = QuantityArrow - 1;
        _shotImpulse = 0;
        CancelInvoke(nameof(ChargeAccumulation));
    }

    private void OnTriggerEnter(Collider other)
    {
        Arrow Arrow = other.GetComponent<Arrow>();

        
        if (Arrow != null)
        {
            GetArrow(Arrow);

        }
    }

    public void GetArrow(Arrow arrow)
    {
        QuantityArrow = QuantityArrow + 1;
        Destroy(arrow.gameObject);
    }

    



}
