using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Text healthValue;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        healthValue.text = health.ToString() + "/" + health.ToString();
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        healthValue.text = health.ToString() + "/" + slider.maxValue.ToString();
    }

}
