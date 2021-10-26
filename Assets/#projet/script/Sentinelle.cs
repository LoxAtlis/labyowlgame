using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Sentinelle : MonoBehaviour
{
    public List<Transform> target = new List<Transform>();
    protected int index = -1;
    protected NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance) {
            NextDestination();
        } 
    }
    protected virtual void NextDestination() {
        index = (index + 1)  % target.Count;
        agent.SetDestination(target[index].position);
    }
}
