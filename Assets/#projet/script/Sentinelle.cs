using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class Sentinelle : MonoBehaviour
{
    public List<Transform> target = new List<Transform>();
    //public List<Transform> targetInvers = new List<Transform>();
    protected int index = -1;
    protected NavMeshAgent agent;
    public enum State
    {
        normal,
        invers
    }
    public State status = State.normal;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextDestination();       
    }   
    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance) {
            switch(status){
                case State.normal: UpdateNormal(); break;
                //case State.invers: UpdateInvers();break;
                //default: UpdateNormal(); break;
            }
        }
    }

    void UpdateNormal(){
        NextDestination();
    }
    protected virtual void NextDestination() {
        index = (index + 1)  % target.Count;
        if(status == State.invers){
            
            index = index--;
        }
        if(index < 0){
            index = target.Count - 1;
        }    
        agent.SetDestination(target[index].position);
    
    }

    // void UpdateInvers(){
    //     NextInversDestination();

    // }
    //  protected virtual void NextInversDestination() {
    //      index = index--;
    //      if(index < 0){
    //         index = target.Count -1;
    //     }
    //     agent.SetDestination(target[index].position);
    //  }
    //     if(status == State.invers){
    //     index = index--;
    //     if(index < 0){
    //         index = tra
    //     }
    //     }
    //     else{
    //     index = (index + 1)  % targetInvers.Count;
    //     }
    //     agent.SetDestination(targetInvers[index].position);
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            status = State.invers;
        }
             
    }



    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         GetComponent<Renderer>().material.SetColor(
    //             "_Color",Color.red
    //         );
    //         //gameObject.transform.position = {-50, 7, -210};
    //         //SceneManager.LoadScene("Lose");
    //     }
    // }
}
