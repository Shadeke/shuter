using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform TargetPoint;
    public Camera CameraLink;
    public float SkyHelper;

   private void Update()
    {
        var ray = CameraLink.ViewportPointToRay(new Vector3(0.5F, 0.7f, 0));

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            TargetPoint.position = hit.point;
        }
        else
        {
            TargetPoint.position = ray.GetPoint(SkyHelper);
        }

        transform.LookAt(TargetPoint.position);
    }
}
