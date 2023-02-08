using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntosNaves : MonoBehaviour
{
    public GameObject textpuntos;
   public static int puntos;
    //public AudioSource collectSound;
    

    void Update()
    {
        textpuntos.GetComponent<Text>().text="PUNTUACION" + puntos;

    }
}
