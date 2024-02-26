using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform CameraHelperTransform;
    public float minAngele;
    public float maxAngle;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * Speed * Input.GetAxis("Mouse X"), 0);
        var newAngeleX = CameraHelperTransform.localEulerAngles.x - Time.deltaTime * Speed * Input.GetAxis("Mouse Y");
        if (newAngeleX > 180)
            newAngeleX -= 360;
        newAngeleX = Mathf.Clamp(newAngeleX, minAngele, maxAngle);
        CameraHelperTransform.localEulerAngles = new Vector3(newAngeleX, 0, 0);
    }
}
