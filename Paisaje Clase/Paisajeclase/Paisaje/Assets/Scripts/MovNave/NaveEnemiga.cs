using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEnemiga : MonoBehaviour
{

    public float speed = 5.0f;

    int puntosruta;



    public WayPoint ruta;

    int puntoactual;

    public float margenhastapunto=0.1f;

    Vector3 siguientepunto;

    void Start()
    {       
        transform.position = ruta.puntosruta[0].position;
        puntoactual=0;
        CalcularSiguientePunto();
        transform.LookAt(ruta.puntosruta[0]);  
    }

    void Update()
    {
        movimiento();
       
    }
    public void movimiento()
    {
       transform.position=Vector3.MoveTowards(transform.position,siguientepunto,speed*Time.deltaTime);
       if(Vector3.Distance(transform.position,siguientepunto)<margenhastapunto)
       {
            CalcularSiguientePunto();    
       }
    }
    public void CalcularSiguientePunto()
    {
        if(puntoactual+1<=ruta.puntosruta.Length-1)
        {
            puntoactual ++;
            siguientepunto = ruta.puntosruta[puntoactual].position;
            transform.LookAt(siguientepunto);

        }
        else
        {
            puntoactual=0;

            siguientepunto = ruta.puntosruta[puntoactual].position;
            transform.LookAt(siguientepunto);
        }   

    }

}
