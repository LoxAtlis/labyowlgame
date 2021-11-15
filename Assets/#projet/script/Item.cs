using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Item : MonoBehaviour
{
    public GameObject PU;
    public Color p;
    public GameObject item;
    private Animator animator;
    
    void start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            PU.GetComponent<SpriteRenderer>().color = new Color (1,1,1,1);
            Destroy(item);
        }
    }
}
