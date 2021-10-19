using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class button : MonoBehaviour
{
    public bool activ;
    public GameObject fond;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnMouseOver(){
        
        activ = !activ;
        fond.SetActive(activ);
        Debug.Log("ouvre toi");
    }
    void OnMouseExit(){
        
        activ = !activ;
        fond.SetActive(activ);
    }
}
