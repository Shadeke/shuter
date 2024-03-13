using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUM : MonoBehaviour
{
    public float MaxSize = 5;
    public float Speed;
    public float Damage = 100000;
    void Start()
    {
        transform.localScale = Vector3.zero;
    }


    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * Speed;
        if(MaxSize <= transform.localScale.x)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(Damage);
        }
        var mob = other.GetComponent<Health>();
        if (mob != null)
        {
            mob.DealDamage(Damage);

        }
    }
}
