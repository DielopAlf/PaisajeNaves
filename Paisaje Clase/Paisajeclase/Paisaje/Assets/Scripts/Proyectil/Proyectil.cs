using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 50f;
    public float daño=10f;
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
        
        rb.velocity=transform.forward*speed*Time.deltaTime;
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
            objeto.gameObject.GetComponent<NaveEnemiga>().aplicardaño(daño);

            Destroy(gameObject);


        }
    }
}

