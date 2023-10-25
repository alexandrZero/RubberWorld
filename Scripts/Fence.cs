using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    [SerializeField] private GameObject[] _fence;
    [SerializeField] private GameObject _fencePrefab;
    [SerializeField] private GameObject _sandBarrierPrefab;
    [SerializeField] private GameObject _woodBarrier_0Prefab;
    [SerializeField] private GameObject _woodBarrier_1Prefab;
    private int _counter;
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _counter++;
            if (_counter == 4)
            {
                _counter = 0;
            }
        }
        if (_counter == 0)
        {
            _fence[0].SetActive(true);
            _fence[1].SetActive(false);
            _fence[2].SetActive(false);
            _fence[3].SetActive(false);
        }
        if (_counter == 1)
        {
            _fence[0].SetActive(false);
            _fence[1].SetActive(true);
            _fence[2].SetActive(false);
            _fence[3].SetActive(false);
        }
        if (_counter == 2)
        {
            _fence[0].SetActive(false);
            _fence[1].SetActive(false);
            _fence[2].SetActive(true);
            _fence[3].SetActive(false);
        }
        if (_counter == 3)
        {
            _fence[0].SetActive(false);
            _fence[1].SetActive(false);
            _fence[2].SetActive(false);
            _fence[3].SetActive(true);
        }
        if (Input.GetMouseButtonUp(0) && Shop._countFence >= 1 && _counter == 0)
        {
            Instantiate(_fencePrefab, _fence[_counter].transform.position,transform.rotation);
            Shop._countFence--;
        }
        if (Input.GetMouseButtonUp(0) && Shop._countSandBarrier >= 1 && _counter == 1)
        {
            Instantiate(_sandBarrierPrefab, _fence[_counter].transform.position, transform.rotation);
            Shop._countSandBarrier--;
        }
        if (Input.GetMouseButtonUp(0) && Shop._countWoodBarrier_0 >= 1 && _counter == 2)
        {
            Instantiate(_woodBarrier_0Prefab, _fence[_counter].transform.position, transform.rotation);
            Shop._countWoodBarrier_0--;
        }
        if (Input.GetMouseButtonUp(0) && Shop._countWoodBarrier_1 >= 1 && _counter == 3)
        {
            Instantiate(_woodBarrier_1Prefab, _fence[_counter].transform.position, transform.rotation);
            Shop._countWoodBarrier_1--;
        }
    }
}
