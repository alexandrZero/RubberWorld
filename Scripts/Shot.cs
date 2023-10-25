using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    private float _runningTime;
    private void Update()
    {
        _runningTime += Time.deltaTime;
        transform.rotation = Quaternion.Euler(GameObject.FindWithTag("Player").transform.rotation.x, CameraWatch.xRot, GameObject.FindWithTag("Player").transform.rotation.z);
    }
    private void FixedUpdate()
    {
        if (_runningTime > 0.33f && SpawnBullet._canSpawn && GunMenu._nowPistol && Bullet._currentBulletPistol > 0)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 0));
            bullet.AddComponent<Bullet>();
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 5000);
            Bullet._currentBulletPistol -= 1;
            _runningTime = 0;
        }
        if (_runningTime > 0.13f && SpawnBullet._canSpawn && GunMenu._nowMachineGun && Bullet._currentBulletMachineGun > 0)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 0));
            bullet.AddComponent<Bullet>();
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 5500);
            Bullet._currentBulletMachineGun -= 1;
            _runningTime = 0;
        }
        if (_runningTime > 1f && SnipeGun._canShot && GunMenu._nowSnipeGun && SnipeGun._isAim && Bullet._currentBulletSnipe > 0)
        {
            GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.Euler(-CameraWatch.yRot, CameraWatch.xRot, 0));
            bullet.AddComponent<Bullet>();
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 8000);
            Bullet._currentBulletSnipe -= 1;
           _runningTime = 0;
        }
    }
}
