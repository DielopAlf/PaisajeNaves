using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class NaveEnemiga : MonoBehaviour
{



    public float speed = 5.0f;
    public GameObject Enemy;
    public float Vida;
    public GameObject textpuntos;
    public int puntos;
    public Text Victoria;
    //public AudioSource collectSound;


    public WayPoint ruta;

    int puntoActual;

    public float margenhastapunto=0.1f;

    Vector3 siguientepunto;

    void Start()
    {       
        transform.position = ruta.puntosruta[0].position;
        puntoActual=0;
        CalcularSiguientePunto();
        transform.LookAt(ruta.puntosruta[0]);  
    }

    void Update()
    {
        Movimiento();
       
    }
    public void Movimiento()
    {
       transform.position=Vector3.MoveTowards(transform.position,siguientepunto,speed*Time.deltaTime);
       if(Vector3.Distance(transform.position,siguientepunto)<margenhastapunto)
       {
            CalcularSiguientePunto();    
       }
    }
    public void CalcularSiguientePunto()
    {
        if(puntoActual+1<=ruta.puntosruta.Length-1)
        {
            puntoActual ++;
            siguientepunto = ruta.puntosruta[puntoActual].position;
            transform.LookAt(siguientepunto);

        }
        else
        {
            puntoActual=0;

            siguientepunto = ruta.puntosruta[puntoActual].position;
            transform.LookAt(siguientepunto);
        }
        if (puntos >= 5) 
        {
            Victoria.gameObject.SetActive(true);


        }

    }

    public void aplicardano(float daño)
    {
        Vida = Vida-daño;
        if(Vida<=0)
        {
            muerte();

        }

    }
    public void muerte()
    {
        //collectSound.Play();
       //PuntosNaves.puntos+=1;
        Destroy(gameObject);
        Debug.Log("puntos");
    }
}
