using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    [SerializeField] GameObject _zombie;
    private float _runningTime;
    private void Update()
    {
        _runningTime += Time.deltaTime;
        if (_runningTime >= 6000)
        {
            Spawn();
            _runningTime = 0;
        }
    }
    private void Spawn()
    {
        Instantiate(_zombie,new Vector3(transform.position.x + 1,transform.position.y + 1,transform.position.z + 1),Quaternion.identity);
    }
}
