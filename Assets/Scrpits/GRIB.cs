using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRIB : MonoBehaviour
{
    public float Delay = 3;
    public GameObject BUMPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", Delay);
    }

    private void Explosion()
    {
        Destroy(gameObject);
        var BUM = Instantiate(BUMPrefab);
        BUM.transform.position = transform.position;
    }

}

