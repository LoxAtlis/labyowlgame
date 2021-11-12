using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   
    public float time = 10f;
    void Start()
    {
        StartCoroutine(timer());
        time += 1;
    }

    // Update is called once per frame
    public  IEnumerator timer(){
        while(time>0){
            time--;
            yield return new WaitForSeconds (1f);
            GetComponent<Text>().text =string.Format("{0:0}:{1:00}",Mathf.Floor(time/60), time % 60);
        }
        if(time == 0){
            SceneManager.LoadScene("Lose");
        }
    }
}
