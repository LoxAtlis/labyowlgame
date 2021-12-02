using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Sentinelle1 : MonoBehaviour
{
    public List<Transform> target = new List<Transform>();
    protected int index = -1;
    protected NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextDestination(); 
    }
    protected virtual void NextDestination() {
        index = (index + 1)  % target.Count;
        if(index < 0){
            index = target.Count - 1;
        }    
        agent.SetDestination(target[index].position);
    
    }
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("ball"))
    //     {
    //         NextInversDestination();
    //     }
    // }
    // protected virtual void NextInversDestination() {
    //     index = (index - 1)  % target.Count;
           
    //     agent.SetDestination(target[index].position);
    
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
