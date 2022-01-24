using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using UnityEngine.Events;

public class TargetPlayer : MonoBehaviour
{
    public Transform _target;
    private NavMeshAgent agent;
    public UnityEvent Patrol;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        _target = player.transform;
        if (Vector3.Distance(agent.transform.position, player.transform.position) < 15)
        {
            agent.SetDestination(_target.position);
        }
        else
        {
            Patrol.Invoke();
        }
    }
}
