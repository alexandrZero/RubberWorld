using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private GameObject _machineGun;
    [SerializeField] private GameObject _SnipeGun;
    private int _value;
    private int _healPoint = 150;
    private void Start()
    {
        _value = Random.Range(0,2);
    }
    private void FixedUpdate()
    {
        if (_healPoint <= 0 && _value == 0)
        {
            Destroy(gameObject);
            Instantiate(_machineGun, transform.position, Quaternion.identity);
            print(0);
        }
        if (_healPoint <= 0 && _value == 1)
        {
            Destroy(gameObject);
            Instantiate(_SnipeGun, transform.position, Quaternion.identity);
            print(1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _healPoint -= Bullet._damage;
        }
    }
}
