using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PilotoNave : MonoBehaviour

   
{
    public GameObject proyectil;
    public float speed =-90.0f;
    public float Timer, TiempoDeEspera;
    public GameObject lugarproyectil;



    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        /*transform.position += transform.forward * Time.deltaTime* speed;

        speed -= transform.forward.y * Time.deltaTime * -50.0f;

        if(speed < 5.0f)
        {
            speed= -5.0f;

        }
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));*/

        if (Input.GetKeyDown(KeyCode.Space))//&& Timer<=0)
        {

            GameObject bala = Instantiate(proyectil,lugarproyectil.transform.position,lugarproyectil.transform.rotation);
            Debug.Log("BALAS");
            //bala.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
            //bala.transform.position = transform.position - transform.forward * 1.5f; 
            //Instantiate(bala, transform.position, Quaternion.Euler(0, 0, -90));
          

            


            // Timer = TiempoDeEspera;
        }
        /*if (aplicardaño.gameObject.tag == "")
        {
            Debug.Log("GOL! DEL Jugador2");
            PuntosNaves.instance.navedestruidas();
        }*/
        //  Timer -= Time.deltaTime;
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("terreno")||other.CompareTag("enemy"))
        {
            PuntosNaves.instance.gAMEOVER();

        }
    }//recuerda que tambien es cuando se acabe el combustible
} 