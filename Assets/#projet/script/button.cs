using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class button : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public Material originalMaterial;

    public Material fond;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    
    void Update()
    {
        
    }
     void OnMouseOver(){
        meshRenderer.material = fond;
        Debug.Log("change");
    }
    void OnMouseExit(){
        meshRenderer.material = originalMaterial;
    }
    // void OnMouseOver(){
        
    //     activ = !activ;
    //     fond.SetActive(activ);
    //     Debug.Log("ouvre toi");
    // }
    // void OnMouseExit(){
        
    //     activ = !activ;
    //     fond.SetActive(activ);
    // }
}
