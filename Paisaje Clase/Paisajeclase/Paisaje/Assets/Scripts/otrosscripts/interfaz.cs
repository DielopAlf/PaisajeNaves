using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class interfaz : MonoBehaviour
{

    public GameObject MenuInicial;

    //Spawner spawner;


    public GameObject botonJugar;
    public GameObject botonopciones;
    public GameObject botonResetear;
    public GameObject Salir;
    // Start is called before the first frame update
    void Start()
    {
        MenuInicial.SetActive(true);

        MenuAlimentar.SetActive(false);
    }

    //desactivar el menu alimentar y activar el  inicial.

    public void DesactivarMenuAlimentar()
    {
        MenuInicial.SetActive(true);
        MenuAlimentar.SetActive(false);
    }
    //Aqui se activara a funcion d edetener el juego creada en el script spawner
    public void DarleAParar()
    {
        spawner.AcaboElJuego();
    }


    //Aqui se activara la funcion de activar el minijuego del script spawner, se quitara el menu principal y aparecerá el de alimentar 
    public void ActivarAlimentar()
    {
        MenuInicial.SetActive(false);
        spawner.ComenzarAlimentacion();
        MenuAlimentar.SetActive(true);
    }
    //cuando se muere la mascota no se podrá acceder al menu alimentar quitandose y se activará el menu inicial pero sin el boton de alimentar-
    // solo aparecera la opcion de reiniciar.
    public void MascotaMuerta()
    {

        DesactivarMenuAlimentar();
        botonAlimentar.SetActive(false);
        botonResetear.SetActive(true);
    }
    //Cuando se muere la mascota le daremos la funcion de reiniciar el juego mediante un boton.
    //se borrarán todos los datos guardados.

    public void ResetearPuntos()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
}
