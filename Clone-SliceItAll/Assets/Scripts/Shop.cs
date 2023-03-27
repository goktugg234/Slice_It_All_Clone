using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public CurrencyController currencyController;
    void Awake()
    {
        currencyController = FindObjectOfType<CurrencyController>();
    }
    public GameObject ShopPrefab;
    public void ShowShop(){
        ShopPrefab.SetActive(true);
    }
    public void HideShop(){
        ShopPrefab.SetActive(false);
    }
}
