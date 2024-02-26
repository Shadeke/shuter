using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyArrow();
    }
    private void DestroyArrow()
    {
        Destroy(gameObject);
    }
}
