using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class Sentinelle : MonoBehaviour
{
    public List<Transform> target = new List<Transform>();
    public float speed;
    
    public int index = -1;
    //public float stop ;
    protected NavMeshAgent agent;
    public Material material2;
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
                case State.invers: UpdateInvers();break;
                default: UpdateNormal(); break;
            }
        }
    }

    void UpdateNormal(){
        NextDestination();
    }
    protected virtual void NextDestination() {
        index = (index + 1)  % target.Count;
        if(index > 2){           
            status = State.invers;       
        }    
        agent.SetDestination(target[index].position);
    
    }

    void UpdateInvers(){
        NextInversDestination();
    }
     protected virtual void NextInversDestination() {
        index = (index - 1)  % target.Count;
        if(index < 0){           
            status = State.normal;       
        }    
        agent.SetDestination(target[index].position);

        // int oldIndex = index;
        
        // while(oldIndex == index) {
        //     oldIndex --;
        // }
        // if(oldIndex < 0){
        //     oldIndex ++;
        // }
    }

    private void OnTriggerEnter(Collider other )
    {
        if (other.gameObject.CompareTag("ball"))
        {
            
            agent.isStopped = true;
            
            StartCoroutine(vitesse());
                //agent.isStopped = false;
            
            status = State.invers;
            
        }
             
    }
    public IEnumerator vitesse(){
        

        yield return new WaitForSeconds(6f);
        agent.isStopped = false ;
        

   }

}
