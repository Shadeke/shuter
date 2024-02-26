using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float Speed;
    public float LifeTime;
    public float Damage = 25;

    private void Start()
    {
        Invoke("DestroyFireBall", LifeTime);
    }
    void FixedUpdate()
    {
        VFireBAll();
    }

    void VFireBAll()
    {
        transform.position += transform.forward * Speed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyFireBall();
        DamageHealth(collision);
    }

    private void DestroyFireBall()
    {
        Destroy(gameObject);
    }
    private void DamageHealth(Collision collision)
    {
        var health = collision.gameObject.GetComponent<Health>();
        if(health != null)
        {
            health.Value -= Damage;
        }
    }
    


}
