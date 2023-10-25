using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private GameObject _panelShop;
    private bool _isShop;
    private readonly int _priceFence = 100;
    private readonly int _priceSandBarrier = 165;
    private readonly int _priceWoodBarrier_0 = 130;
    private readonly int _priceWoodBarrier_1 = 150;
    public void OnClick()
    {
        _isShop = !_isShop;
        _panelShop.SetActive(_isShop);
    }
    public void BuyFence()
    {
        if (Shop._zombieCoin >= _priceFence)
        {
            Shop._zombieCoin -= _priceFence;
            Shop._countFence++;
            GunMenu._haveFence = true;
        }
    }
    public void BuySandBarrier()
    {
        if (Shop._zombieCoin >= _priceSandBarrier)
        {
            Shop._zombieCoin -= _priceSandBarrier;
            Shop._countSandBarrier++;
            GunMenu._haveFence = true;
        }
    }
    public void BuyWoodBarrier_0()
    {
        if (Shop._zombieCoin >= _priceWoodBarrier_0)
        {
            Shop._zombieCoin -= _priceWoodBarrier_0;
            Shop._countWoodBarrier_0++;
            GunMenu._haveFence = true;
        }
    }
    public void BuyWoodBarrier_1()
    {
        if (Shop._zombieCoin >= _priceWoodBarrier_1)
        {
            Shop._zombieCoin -= _priceWoodBarrier_1;
            Shop._countWoodBarrier_1++;
            GunMenu._haveFence = true;
        }
    }
}
