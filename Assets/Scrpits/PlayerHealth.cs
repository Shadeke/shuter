using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MaxValue = 100;
    public Slider HealthBar;
    public  GameObject PlayerUI;
    public GameObject GameOverUI;
    public float RepearScene = 1;
    public float DM = 25;

    private float CurrentValue;


    void Start()
    {
        CurrentValue = 100;
        UpdateHealthbar();
    }

   
   public void TakeDamage(float damage)
    {
        CurrentValue -= DM;
        if(CurrentValue <= 0)
        {
            CurrentValue = 0;
            RepearScene = 0;
            PlayerUI.SetActive(false);
            GameOverUI.SetActive(true);
            GetComponent<Controller>().enabled = false;
            GetComponent<CameraRotation>().enabled = false;
            
        }
        UpdateHealthbar();
       
    }

    void UpdateHealthbar()
    {
        HealthBar.value = CurrentValue/MaxValue;
    }

   


}
