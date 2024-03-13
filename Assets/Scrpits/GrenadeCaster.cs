using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    public Transform grenadSourceTransform;
    public float force = 30;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
           var grenade = Instantiate(grenadePrefab);
            grenade.transform.position = grenadSourceTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadSourceTransform.forward * force);
        }
    }
}
