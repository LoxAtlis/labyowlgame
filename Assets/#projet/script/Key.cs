using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Key : MonoBehaviour
{   
    public GameObject key;
    
    public static int cle ;
    public TextMeshProUGUI tmpText;   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player") )
        {
            //key.GetComponent<MeshRenderer> ().material = material0;     
            cle ++;
            tmpText.text= ": "+cle.ToString("N0");
            Debug.Log("nbr clé"+cle);
            Destroy(key);
            
        }   
    }
    

}
