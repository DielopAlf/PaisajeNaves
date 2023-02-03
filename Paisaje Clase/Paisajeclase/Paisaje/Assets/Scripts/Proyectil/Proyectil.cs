using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed;
    void Start()
    {
      //  Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,speed * Time.deltaTime, 0);
        //transform.position += transform.up * Time.deltaTime * speed*2;

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.CompareTag("Enemy"))

        {
            collision.gameObject.GetComponent<NaveEnemiga>().Vida -= 1;
        }
    }
}

