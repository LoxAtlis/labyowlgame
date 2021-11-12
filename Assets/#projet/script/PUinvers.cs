using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PUinvers : MonoBehaviour
{
    public List<GameObject> balls = new List<GameObject>();
    public GameObject powerUpBall;

    public Transform pUBall;

    public float ballSpeed ;
    public float delay ;
    
    public enum State{
        normal,
        shoot
    }
    void Start()
    {
        
    }

    public State status = State.normal;
    void Update()
    {
        switch(status){
            case State.normal: UpdateNormal(); break;
            //case State.shoot: ShootV();break;
        }
    }
    void UpdateNormal(){

    }
   
    private void ShootV(InputAction.CallbackContext context){
        if(context.performed){
            Debug.Log("Pan");
            GameObject newBall = Instantiate(powerUpBall, pUBall.position,pUBall.rotation);
            Rigidbody ballRigid = newBall.GetComponent<Rigidbody>();
            balls.Add(newBall);
            ballRigid.velocity = pUBall.forward*ballSpeed;
            Deleteball();
            
        }
    }

    public void Deleteball(){
        for(int i = 0; i < balls.Count; i++) 
        {
            
            Destroy(balls[i], delay);
            
        }
        balls.Clear();
    }
    

    private void OnTriggerEnter(Collider other){
        if( other.gameObject.CompareTag("item")){
            
            status = State.shoot;
        }
    }
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("ennemi"))
    //     {
    //         Destroy(balls[i]);
    //     }
    // }
    //  void OnShoot(InputValue value)
    // {
    //     if(value.isPressed)
    //     {
    //         Shoot();
    //     }
    // }
    // void Shoot(){
    //     GameObject newBall = Instantiate(powerUpBall, pUBall.position,pUBall.rotation);
    //     Rigidbody ballRigid = newBall.GetComponent<Rigidbody>();
    //     ballRigid.velocity = pUBall.forward*ballSpeed;

    // }
    // yield return new WaitForSeconds(delay);
    //         Deleteball();
}
