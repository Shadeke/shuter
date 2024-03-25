using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobCheker : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject Finale;

    void Update()
    {
        if(GameObject.Find("Mob") == null & GameObject.Find("Mob1") == null& GameObject.Find("Mob2") == null& GameObject.Find("Mob3") == null& GameObject.Find("Mob4") == null)
        {
            Debug.Log("Win");
            PlayerUI.SetActive(false);
            Finale.SetActive(true);
        }
    }

   
}

