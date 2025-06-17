using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;


    private void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.name == "Player")
        {
            if (gameObject.name == "GoldenEgg")
            {
                moneyManager.UpdateMoney(+precio);
                Destroy(gameObject);
                return;
            }
            bool leAlcanza = moneyManager.UpdateMoney(-precio);
            if (leAlcanza)
            {
                Destroy(gameObject);
            }
        }
    }
}
    