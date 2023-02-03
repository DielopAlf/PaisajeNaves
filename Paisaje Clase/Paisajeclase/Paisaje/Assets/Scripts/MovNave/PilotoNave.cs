using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotoNave : MonoBehaviour

   
{
    public GameObject proyectil;
    public float speed =-90.0f;
    public float Timer, TiempoDeEspera;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime* speed;

        speed -= transform.forward.y * Time.deltaTime * -50.0f;

        if(speed < 5.0f)
        {
            speed= -5.0f;

        }
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        if (Input.GetKeyUp(KeyCode.Space)&& Timer<=0)
        {

            GameObject bala = Instantiate(proyectil);
            
            //bala.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
            //bala.transform.position = transform.position - transform.forward * 1.5f;
          //  Instantiate(bala, transform.position, Quaternion.Euler(0, 0, -90));

            // Timer = TiempoDeEspera;
        }
        //  Timer -= Time.deltaTime;

    }
}
