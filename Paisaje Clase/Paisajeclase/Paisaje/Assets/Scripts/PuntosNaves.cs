using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PuntosNaves : MonoBehaviour
{
   public TextMeshProUGUI textpuntos;

   public static PuntosNaves instance;
    int navesdestruidas;



    // public TextMeshPro puntuacion;
    //public AudioSource collectSound;

    private void Awake()
    {
        if (PuntosNaves.instance == null)
        {

            PuntosNaves.instance = this;

        }
        else
        {
            Destroy(this);


        }
    }

    void Start()
    {
        navesdestruidas=0;
    }

    public void navedestruidas()
    {
        navesdestruidas++;
        textpuntos.text = navesdestruidas.ToString() + "= / 5";

    }

    /*void Update()
    {
        // textpuntos.GetComponent<TextMeshProUGUI>().text="Naves 0/5" + puntos;

    }*/
}
