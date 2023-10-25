using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolGun : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Animator _animator; 
    private float _runnigTime;
    private void Update()
    {
        _runnigTime += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && Bullet._currentBulletPistol > 0)
        {
            if (_runnigTime > 0.25f)
            {
                SpawnBullet._canSpawn = true;
                _particleSystem.Play();
                _runnigTime = 0;
                _animator.SetInteger("Pistol", 1);
            }
        }
        if (Input.GetMouseButton(0) == false)
        {
            SpawnBullet._canSpawn = false;
            _animator.SetInteger("Pistol", 0);
            _particleSystem.Stop();
        }
        if (Bullet._currentBulletPistol == 0)
        {
            SpawnBullet._canSpawn = false;
            _particleSystem.Stop();
        }
        if (Input.GetKeyDown(KeyCode.R) && Input.GetMouseButton(0) == false &&  Bullet._currentBulletPistol < Bullet._magazinePistol && Bullet._countBulletPistol > 0)
        {
            _animator.SetInteger("Pistol", 2);
            if (Bullet._countBulletPistol >= Bullet._magazinePistol)
            {
                Bullet._countBulletPistol -= -(Bullet._currentBulletPistol - Bullet._magazinePistol);
                Bullet._currentBulletPistol = Bullet._magazinePistol;
            }
            if (Bullet._countBulletPistol <= Bullet._magazinePistol)
            {
                Bullet._countBulletPistol = 0;
                Bullet._currentBulletPistol = Bullet._countBulletPistol;
            }
        }
    }
}
