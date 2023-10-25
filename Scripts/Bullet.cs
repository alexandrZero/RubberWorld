using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    private float _time = 7;
    public static readonly int _magazinePistol = 14;
    public static readonly int _magazineMachineGun = 30;
    public static readonly int _magazineSnipe = 8;
    public static int _damage = 10;
    public static int _countBulletPistol = 120;
    public static int _countBulletMachineGun = 400;
    public static int _countBulletSnipe = 50;
    public static int _currentBulletPistol = 14;
    public static int _currentBulletMachineGun = 30;
    public static int _currentBulletSnipe = 8;
    private void Start()
    {
        Invoke("DestroyGameObject", _time);
    }
    private void FixedUpdate()
    {
        if (GunMenu._nowPistol)
        {
            _damage = 10;
        }
        if (GunMenu._nowMachineGun)
        {
            _damage = 25;
        }
        if (GunMenu._nowSnipeGun)
        {
            _damage = 1000;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie" || collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
        }
    }
    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
