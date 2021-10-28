using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaisseau : MonoBehaviour
{
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
            GetComponent<Renderer>().material.SetColor(
                "_Color",Color.red
            );
            //gameObject.transform.position = {-50, 7, -210};
            //SceneManager.LoadScene("Lose");
        }
    }
}
