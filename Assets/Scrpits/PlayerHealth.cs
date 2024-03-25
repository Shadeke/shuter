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
    public GameObject HealEffect;


    private float _CurrentValue;
   



    void Start()
    {
        _CurrentValue = MaxValue;
        UpdateHealthbar();
    }

   
   public void TakeDamage(float damage)
    {
        _CurrentValue -= damage;
        if(_CurrentValue <= 0)
        {

            PlayerUI.SetActive(false);
            GameOverUI.SetActive(true);
            GetComponent<Controller>().enabled = false;
            GetComponent<CameraRotation>().enabled = false;
            
        }
        UpdateHealthbar();
       
    }

    public void AddHealth(float amout)
    {
        _CurrentValue = _CurrentValue + amout;
        if (_CurrentValue > MaxValue)
        {
            _CurrentValue = MaxValue;
        }
        HealEffect.GetComponent<ParticleSystem>().Play();
        UpdateHealthbar();
    }

    void UpdateHealthbar()
    {
        HealthBar.value = _CurrentValue;
    }

   


}
