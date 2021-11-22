using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public Material open;
    public Material close;
    //GetComponent<Key>();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // private void OnTriggerEnter(Collider other){
    //     if (other.gameObject.CompareTag("Player") && cle >=1)
    //     {
            
    //         door.GetComponent<MeshRenderer> ().material = open;
    //         Destroy(door);
            
    //         cle -= 1;
    //         Debug.Log("nbr"+cle);
            
    //     }
    // }
    // private void OnTriggerExit(Collider other){
    //     door.GetComponent<MeshRenderer> ().material = close;
    // }

}
