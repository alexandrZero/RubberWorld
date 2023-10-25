using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    public static bool _canSpawn;
    private float _runningTime;
    private void Update()
    {
        _runningTime += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if (_runningTime >= 0.33f && _canSpawn && GunMenu._nowPistol)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 180));
            bullet.AddComponent<Bullet>();
            _runningTime = 0;
        }
        if (_runningTime >= 0.13f && _canSpawn && GunMenu._nowMachineGun)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 180));
            bullet.AddComponent<Bullet>();
            _runningTime = 0;
        }
        if (_runningTime >= 1f && _canSpawn && GunMenu._nowSnipeGun)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 180));
            bullet.AddComponent<Bullet>();
            _runningTime = 0;
        }
    }
}
