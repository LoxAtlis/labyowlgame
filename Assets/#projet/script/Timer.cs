using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   
    private float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer =+ Time.deltaTime;
    }
}
