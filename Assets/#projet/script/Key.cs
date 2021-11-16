using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Key : MonoBehaviour
{
    public List<int> cles = new List<int>();
    public GameObject key;
    public GameObject door;
    public Transform keyOrigin;
    public Material material1;
    public Material material0;
    private int cle = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
        {
            key.GetComponent<MeshRenderer> ().material = material0;
        }
        
    }
    private void OnTriggerExit(Collider other){
        key.GetComponent<MeshRenderer> ().material = material1;
    }
    public void Open(InputAction.CallbackContext context){
        Instantiate(key, keyOrigin.position,keyOrigin.rotation);
        Destroy(key);        
        cle +=1;
    }



}
