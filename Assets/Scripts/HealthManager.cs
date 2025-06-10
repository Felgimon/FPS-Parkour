using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI vidaUI;
    public UIManager uiManager;
    public float health;

    void Start()
    {
        uiManager.UpdateHealthText(health.ToString());
    }

    public bool UpdateHealth(float amount)
    {
        if (health + amount <= 0)
        {
            Debug.Log("Te moriste");
            SceneManager.LoadScene("Parkour");
            return false;
        }
        health += amount;
        uiManager.UpdateHealthText(health.ToString());
        return true;
    }
}

