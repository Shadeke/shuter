using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBaller : MonoBehaviour
{
    public FireBall FireBallPrefab;
    public Transform MomOfFireBall;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(FireBallPrefab, MomOfFireBall.position, MomOfFireBall.rotation);
           
        }
    }
}
