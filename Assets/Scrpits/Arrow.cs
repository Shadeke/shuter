using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody RG;

    void Update()
    {
        BowShot();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyArrow();
    }
    private void DestroyArrow()
    {
        Destroy(gameObject);
    }
     void BowShot()
    {
        var Shot = gameObject.GetComponent<Bow>();
        if (Input.GetMouseButtonUp(0) && Shot.ShotImpulse > 0)
        {
            RG.AddForce(Vector3.forward * Shot.ShotImpulse, ForceMode.Impulse);
        }

    }

}
