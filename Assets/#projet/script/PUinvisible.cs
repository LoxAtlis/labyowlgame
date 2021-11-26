using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PUinvisible : MonoBehaviour
{
    public GameObject surv;
    //public bool desa = true;
    void Start()
    {
        
    }
    public void desactiver(InputAction.CallbackContext context ){
        if(context.performed ){
            Debug.Log("disp");
            surv.SetActive(false);
        }
        else{
            Update();

        }
    }
   public IEnumerator changeActive(){
       yield return new WaitForSeconds(5f);
       surv.SetActive(true);

   }
    void Update()
    {
        StartCoroutine(changeActive());
    }
    
    
}
