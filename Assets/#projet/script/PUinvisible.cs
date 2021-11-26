using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PUinvisible : MonoBehaviour
{
    public GameObject surv,surv1,surv2;
    //public bool desa = true;
    public bool desa = false;
    void Start()
    {
        
    }
    public void desactiver(InputAction.CallbackContext context ){
        if(context.performed && desa ){
            Debug.Log("disp");
            surv.SetActive(false);
            surv1.SetActive(false);
            surv2.SetActive(false);
            StartCoroutine(changeActive());
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PU"))
        {
            desa = true;
        }
    }
    void Update()
    {
        //StartCoroutine(changeActive());
    }
   public IEnumerator changeActive(){
       yield return new WaitForSeconds(5f);
       surv.SetActive(true);
       surv1.SetActive(true);
       surv2.SetActive(true);

   }
    
}
