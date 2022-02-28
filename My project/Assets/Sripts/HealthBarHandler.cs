using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    private Image HealthBar;

    public HealthBarHandler(Image _healthBar)
    {
        HealthBar = _healthBar;
        SetHealthBarValue(1);
    }

    private void Start()
    {

    }

    public void SetHealthBarValue(float value)
    {
        HealthBar.fillAmount = value;
        if (HealthBar.fillAmount < 0.2f)
        {
            SetHealthBarColor(Color.red);
        }
        else if (HealthBar.fillAmount < 0.4f)
        {
            SetHealthBarColor(Color.yellow);
        }
        else
        {
            SetHealthBarColor(Color.green);
        }
    }

    public float GetHealthBarValue()
    {
        return HealthBar.fillAmount;
    }

    public void SetHealthBarColor(Color healthColor)
    {
        HealthBar.color = healthColor;
    }

}
