using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PUinvers : Item
{
    public List<GameObject> balls = new List<GameObject>();
    public GameObject powerUpBall;
    public Transform pUBall;
    public GameObject powerUp;
    

    public float ballSpeed ;
    public float delay ;
    
    public bool shoot = false;
    void Start()
    {
        //() = shoot;
    }   
    void Update()
    {

    } 
    private void ShootV(InputAction.CallbackContext context ){
        
        if(context.performed && shoot ){
            //Debug.Log("Pan");
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
    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            shoot = true;
        }
        
    }
    
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
