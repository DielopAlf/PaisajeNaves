using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEnemiga : MonoBehaviour
{

    float speed = 5.0f;

    public Transform target;

    public WayPoint ruta;

    int puntoactual;

    

    void Start()
    {       
        transform.position = ruta.puntoruta[0].position;

        transform.LookAt(ruta.puntoruta[0]);  
    }

    void Update()
    {
        //transform.Translate(new Vector3(0, 0, speed*Time.deltaTime)); 
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag =="WayPoint")
        {
            target=other.gameObject.GetComponent<WayPoint>().siguientePunto;
            //transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));
        }
    }

}
