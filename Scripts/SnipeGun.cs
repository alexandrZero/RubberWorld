using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnipeGun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _aim;
    [SerializeField] private GameObject _main;
    [SerializeField] private GameObject _focus;
    [SerializeField] private Animator _animator;
    private bool _isFocus;
    public static bool _isAim;
    public static bool _canShot = false;
    private void FixedUpdate()
    {
        if (_aim.activeSelf)
        {
            _isAim = true;
        }
        else
        {
            _isAim = false;
        }
        if (_isFocus)
        {
            Camera.main.fieldOfView = 20;
        }
        else
        {
            Camera.main.fieldOfView = 60;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _isFocus = !_isFocus;
            _focus.SetActive(_isFocus);
            _main.SetActive(!_isFocus);
            _aim.SetActive(_isFocus);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _canShot = true;
            SpawnBullet._canSpawn = true;
        }
        if (Input.GetMouseButtonDown(0) == false)
        {
            _canShot = false;
            SpawnBullet._canSpawn = false;
        }
        if (Input.GetKeyDown(KeyCode.R) && Input.GetMouseButton(0) == false && Bullet._currentBulletSnipe < Bullet._magazineSnipe && Bullet._countBulletSnipe > 0)
        {
            _animator.SetInteger("Sniper", 1);
            if (Bullet._countBulletSnipe >= Bullet._magazineSnipe)
            {
                Bullet._countBulletSnipe -= -(Bullet._currentBulletSnipe - Bullet._magazineSnipe);
                Bullet._currentBulletSnipe = Bullet._magazineSnipe;
            }
            if (Bullet._countBulletSnipe <= Bullet._magazineSnipe)
            {
                Bullet._countBulletSnipe = 0;
                Bullet._currentBulletSnipe = Bullet._countBulletSnipe;
            }
        }
    }
}
