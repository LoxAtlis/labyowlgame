using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject ui;
    //private bool pause = false;
    void Start()
    {
        
    }
    public void pauseG(InputAction.CallbackContext context ){
        if(context.performed )
        {
            Toggle();
        }
    }

    public void Toggle(){  
        ui.SetActive(!ui.activeSelf);
        if(ui.activeSelf){
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
   
}
