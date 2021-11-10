using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PUinvers : MonoBehaviour
{
    public GameObject powerUpBall;

    public Transform pUBall;

    public float ballSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    // public void ShootV(InputAction.CallbackContext context){
    //     if(context.performed){
    //         Debug.Log("PAN!");
    //     }
    // }
     void OnShoot(InputValue value)
    {
        if(value.isPressed)
        {
            Shoot();
        }
    }
    void Shoot(){
        GameObject newBall = Instantiate(powerUpBall, pUBall.position,pUBall.rotation);
        Rigidbody ballRigid = newBall.GetComponent<Rigidbody>();
        ballRigid.velocity = pUBall.forward*ballSpeed;

    }
}
