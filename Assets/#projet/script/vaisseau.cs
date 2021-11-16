using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaisseau : MonoBehaviour
{
    public Material material1;
    public Material material2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer> ().material = material2;
        }       
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer> ().material = material1;
               
    }
}
