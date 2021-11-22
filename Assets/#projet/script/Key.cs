using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Key : MonoBehaviour
{   
    public GameObject door,key,doorbox;
    public Material material1,material0,open,close;
    public int cle ;
    public TextMeshProUGUI tmpText;   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("cle") )
        {
            //key.GetComponent<MeshRenderer> ().material = material0;
            //Open().SetActive = true;
            Destroy(key);
                
            cle += 1;
            tmpText.text= ": "+cle.ToString("N0");
            Debug.Log("nbr clé"+cle);
            
        }   
        

        if (other.gameObject.CompareTag("porte"))
        {
            door.GetComponent<MeshRenderer> ().material = open; 
            if(cle >= 1){
                cle -- ; 
                tmpText.text= ": "+cle.ToString("N0");  
                Destroy(door);

            }    
        }       
    }
    // public void Open(InputAction.CallbackContext context){
        

    // }
    public void OnTriggerExit(Collider other){
        key.GetComponent<MeshRenderer> ().material = material1;
        door.GetComponent<MeshRenderer> ().material = close;
    }
    

}
