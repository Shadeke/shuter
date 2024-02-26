using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Potrule : MonoBehaviour
{
    public List<Transform> PatrolePoins;

    NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        if (_navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance)
        {
            _navMeshAgent.SetDestination(PatrolePoins[Random.Range(0, PatrolePoins.Count)].position);
        }
    }
}
