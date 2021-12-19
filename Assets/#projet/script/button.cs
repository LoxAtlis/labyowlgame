using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class button : MonoBehaviour
{
    public GameObject fenetre;
    public bool desa = false;

    public void Active(){
        fenetre.SetActive(true);
    }

    public void Desactiver(){
        fenetre.SetActive(false);
    }
}
