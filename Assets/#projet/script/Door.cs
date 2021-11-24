using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    public GameObject door;  
    public Material open,close;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
        {
            door.GetComponent<MeshRenderer> ().material = open; 
            //int cle = GetComponent<Key>().cle;
            //Key.cle
            if(Key.cle >= 1){
                Key.cle -- ; 
                tmpText.text= ": "+Key.cle.ToString("N0");  
                Destroy(door);
                Debug.Log(Key.cle);

            }    
        }      
    }
    public void OnTriggerExit(Collider other){
        
        door.GetComponent<MeshRenderer> ().material = close;
    }
}
