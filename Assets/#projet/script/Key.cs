using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public GameObject doorbox;
    public Material material1;
    public Material material0;
    public Material open;
    public Material close;
    public int cle ;
    public TextMeshProUGUI tmpText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("cle") )
        {
            key.GetComponent<MeshRenderer> ().material = material0;
        }

        if (other.gameObject.CompareTag("porte"))
        {
            door.GetComponent<MeshRenderer> ().material = open; 
            Debug.Log("nbr"+cle);    
            if(cle >= 1){
                cle -= 1;
                Destroy(door);

            }    
        }       
    }
    public void OnTriggerExit(Collider other){
        key.GetComponent<MeshRenderer> ().material = material1;
        door.GetComponent<MeshRenderer> ().material = close;
    }
    public void Open(InputAction.CallbackContext context){
        Destroy(key);        
        cle += 1;
        tmpText.text= ": "+cle.ToString("N0");
        Debug.Log("nbr clé"+cle);
    }

}
