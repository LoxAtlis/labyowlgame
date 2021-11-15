using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlCenter : MonoBehaviour
{
    public float degres ;
    public float speed;
    
    void Start()
    {
       StartCoroutine(RotateObject(45, Vector3.up, 1));
    }
    IEnumerator RotateObject(float degres, Vector3 axis, float speed){
        float rotationSpeed = degres / speed;
        while (true){
            Quaternion startRotation = transform.rotation;
            float deltaAngle = 10;
            while (deltaAngle < degres){
                deltaAngle += rotationSpeed * Time.deltaTime;
                deltaAngle = Mathf.Min(deltaAngle, degres);
                transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);
                yield return null;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
