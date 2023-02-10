/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    int puntoActual;
    public WayPoint ruta;
    public GameObject powerup;
    public float tiempominimo = 20;
    public float tiempoMaximo = 40;
    bool estaActivo;
    public GameObject malla;
    float temporizador;


    void Start()
    {
        //ScriptNave = player.GetComponent<player>();
        transform.position = ruta.puntosruta[0].position;
        puntoActual = 0;
        Vector3 siguientepunto;
        void Start()
        {
            transform.position = ruta.puntosruta[0].position;
            puntoActual = 0;
            CalcularSiguientePunto();
            transform.LookAt(ruta.puntosruta[0]);
            barradevida.maxValue = Vida;
            barradevida.value = Vida;

        }
    }

    public void Aparecer()
    {
        powerup.SetActive(true);


    }
    temporizador = Random.Range(tiempominimo, tiempoMaximo);

       


        void Update()
    {

    }
    public IEnumerator ResetearPowerUp()
    {
        yield return new WaitForSeconds(Random.Range(1f, 6f));
        Aparecer();

    }
}*/


