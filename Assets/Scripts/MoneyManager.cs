using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI dineroUI;
    public UIManager uiManager;
    public float money;

    private void Start()
    {
        uiManager.UpdateMoneyText(money.ToString());
    }
    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No es posible realizar la acción");
            return false;
        }
        money += amount;
        uiManager.UpdateMoneyText(money.ToString());
        return true;
    }
}
