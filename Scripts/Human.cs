using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Human : MonoBehaviour
{
    private NavMeshAgent _agent;
    private float _runningTime = 6;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        _runningTime += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if (_runningTime >= 7)
        {
            _agent.SetDestination(new Vector3(Random.Range(0, 500), transform.position.y, Random.Range(900, 1200)));
            _runningTime = 0;
        }
        print(NavMeshPathStatus.PathComplete);
        print(NavMeshPathStatus.PathPartial);
        print(NavMeshPathStatus.PathInvalid);
    }
}
