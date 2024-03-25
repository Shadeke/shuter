using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public List<Transform> Points;
    public Controller Player;
    public float ViewAngele;
    public float MinDetectDistance;

    private NavMeshAgent _navMeshAgent;
    private bool _isPlayer;
    private float HitDistance = 1f;
    

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();

    }
   
    void Update()
    {
        var direction = Player.transform.position - transform.position;

        PlayerCheck();
        var _hp = Player.GetComponent<PlayerHealth>();
        if (_isPlayer == true)
        {
            _navMeshAgent.SetDestination(Player.transform.position);
            if(_navMeshAgent.remainingDistance <= HitDistance)
            {
                _hp.TakeDamage(25 * Time.deltaTime);
            }
        }


        // Погоня
        if (_isPlayer)
        {
            _navMeshAgent.destination = Player.transform.position;
        }
        if(_isPlayer == false)
        {
            if (_navMeshAgent.remainingDistance == 0)
            {
                _navMeshAgent.destination = Points[Random.Range(0, Points.Count)].position;
            }
        }
        

    }
     void PlayerCheck()
    {
        var direction = Player.transform.position - transform.position;
        _isPlayer = false;
        if (Vector3.Angle(transform.forward, direction) < ViewAngele)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up, direction, out hit))
            {
                if (hit.collider.gameObject == Player.gameObject)
                {
                    _isPlayer = true;
                }

                if (_navMeshAgent.remainingDistance == 0)
                {
                    _navMeshAgent.destination = Points[Random.Range(0, Points.Count)].position;
                }

            }
        }
       
    }
}
