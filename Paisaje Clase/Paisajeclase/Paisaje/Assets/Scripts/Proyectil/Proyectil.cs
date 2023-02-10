using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proyectil : MonoBehaviour
{
    Rigidbody rb;
    public float speedbala = 50f;
    public float dano=10f;
    Vector3 puntoinicial;
    public float alcance=100f;
    void Start()
    {

       rb = this.GetComponent<Rigidbody>();
        puntoinicial=gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity=transform.forward*speedbala*Time.deltaTime;
        float Distancia = Vector3.Distance(transform.position,puntoinicial);
        if (Distancia>alcance)
        {

            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter(Collider objeto)
    {

        if (objeto.CompareTag("Enemy"))
        {
            objeto.gameObject.GetComponent<NaveEnemiga>().aplicardano(dano);
            Destroy(gameObject);


        }

        /*if (other.CompareTag("Lata") && combustibleinicial > 0f)
        {
            combustible += 30f;


            if (combustible > combustibleinicial)
            {
                combustible = combustibleinicial;


            }
            Debug.Log("destruida");
            Destroy(other.gameObject);

        }*/

    }
    public void cogerpowerup()

    {


    }
}

