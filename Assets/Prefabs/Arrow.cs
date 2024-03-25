using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class Arrow : MonoBehaviour
{

    public float Damage = 50;

    private void OnCollisionEnter(Collision collision)
    {
        StayArrow();
    }
    private void StayArrow()
    {
        var rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

        var bc = GetComponent<BoxCollider>();
        bc.isTrigger = true;
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var mob = other.GetComponent<Health>();
        if (mob != null)
        {
            mob.DealDamage(Damage);
            Destroy(gameObject);

        }
    }


}


