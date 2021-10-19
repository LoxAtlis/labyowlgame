using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 moveVector;
    public float movementSpeed;
    public CharacterController controller;
    //float verticalSpeed;
    //public float gravityMultiplier;
    public void Move(InputAction.CallbackContext context){
        moveVector = context.ReadValue<Vector2>();
        Debug.Log(moveVector);
        
    }
    void Update()
    {
        
        
       transform.position += new Vector3(moveVector.x,0, moveVector.y)*movementSpeed; 

        Vector3 movement = new Vector3(moveVector.x,0, moveVector.y)*movementSpeed;

       if (movement.magnitude > 0){
            transform.forward = Vector3.Lerp(transform.forward, movement, 0.009f);
        }
        
        controller.Move (movement*Time.deltaTime);
       
    }
}
