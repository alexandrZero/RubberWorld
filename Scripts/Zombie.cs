using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    private NavMeshAgent _agent;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        _agent.destination = GameObject.FindWithTag("Player").transform.position;
        GetComponent<Animator>().SetInteger("Zombie", 1);
    }
}
