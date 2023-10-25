using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject _spriteShop;
    [SerializeField] private GameObject _panelShop;
    [SerializeField] private TextMesh _text;
    public static int _zombieCoin = 1000;
    public static int _countFence;
    public static int _countSandBarrier;
    public static int _countWoodBarrier_0;
    public static int _countWoodBarrier_1;
    private void FixedUpdate()
    {
      _text.text = _zombieCoin.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            _spriteShop.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            _spriteShop.SetActive(false);
            _panelShop.SetActive(false);
        }
    }
}
