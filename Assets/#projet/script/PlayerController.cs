using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 moveVector;
    public float movementSpeed;
    public CharacterController controller;
    public Transform CameraP;
   
    //public float gravityMultiplier;
    public void Move(InputAction.CallbackContext context){
        moveVector = context.ReadValue<Vector2>();
        Debug.Log(moveVector);
        
    }
    void Update()
    {
        Vector3 cameraPlayer = new Vector3();
        cameraPlayer = transform.position-CameraP.position;
        Vector3 cameraPlayer2D = new Vector3(cameraPlayer.x,0,cameraPlayer.z);
        cameraPlayer2D = cameraPlayer2D.normalized;
        Vector3 move = Vector3.zero;
        
        if(moveVector.x != 0){
            move = transform.right * moveVector.x;
        }

        if(moveVector.y != 0){
            move = cameraPlayer2D * moveVector.y;
        }
        move *= movementSpeed;

         if(move!= Vector3.zero ){
            transform.forward = cameraPlayer2D;
        }
        
        // transform.position += new Vector3(moveVector.x,0, moveVector.y)*movementSpeed; 

        //    Vector3 movement = new Vector3(moveVector.x,0, moveVector.y)*movementSpeed;

        // if (movement.magnitude > 0){
        //      transform.forward = Vector3.Lerp(transform.forward, movement, 0.009f);
        //  }
        
        controller.Move (move*Time.deltaTime);
       
    }
}
