using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    public Transform _target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var destP = Points[Random.Range(0, Points.Length)];
       
        
        if (!agent.pathPending && agent.remainingDistance <= 0.5f )
        {
            agent.destination = destP.position;
        }
       
    }
}
