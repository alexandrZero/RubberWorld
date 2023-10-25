using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
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
        if (Input.GetMouseButton(0))
        {
            if (_runnigTime > 0.07f)
            {
                SpawnBullet._canSpawn = true;
                _particleSystem.Play();
                _runnigTime = 0;
                _animator.SetInteger("MachineGun", 1);
            }
        }
        if (Input.GetMouseButton(0) == false)
        {
            SpawnBullet._canSpawn = false;
            _animator.SetInteger("MachineGun", 0);
            _particleSystem.Stop();
        }
        if (Input.GetKeyDown(KeyCode.R) && Input.GetMouseButton(0) == false && Bullet._currentBulletMachineGun < Bullet._magazineMachineGun && Bullet._countBulletMachineGun > 0)
        {
            _animator.SetInteger("MachineGun", 2);
            if (Bullet._countBulletMachineGun >= Bullet._magazineMachineGun)
            {
                Bullet._countBulletMachineGun -= -(Bullet._currentBulletMachineGun - Bullet._magazineMachineGun);
                Bullet._currentBulletMachineGun = Bullet._magazineMachineGun;
            }
            if (Bullet._countBulletMachineGun <= Bullet._magazineMachineGun)
            {
                Bullet._countBulletMachineGun = 0;
                Bullet._currentBulletMachineGun = Bullet._countBulletMachineGun;
            }
        }
    }
}
