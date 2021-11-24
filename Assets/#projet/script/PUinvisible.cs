using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PUinvisible : MonoBehaviour
{
    public float time = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(timer());
        time += 1;
    }
    public  IEnumerator timer(){
        while(time>0){
            time--;
            yield return new WaitForSeconds (1f);
            GetComponent<Text>().text =string.Format("{0:0}:{1:00}",Mathf.Floor(time/60), time % 60);
        }
        if(time == 0){
            
        }
    }
}
