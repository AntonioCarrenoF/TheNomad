using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    /**
     * Clase para hacer que el jugador dispare una bala y baje la salud actual de los NPC enemigos, \n
     * La clase DispararNPC, la cuál sirve para que el NPC dispare una bala al jugador hereda de ésta clase.
     */


    public float velocidadDisparo = 10f;
    public float distanciaDisparo = 50f;
    public GameObject prefabBala;
    public AudioClip Disparo;
    private AudioSource fuenteDeSonido;

    // Start is called before the first frame update
    void Start()
    {
        fuenteDeSonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DispararArma();
        }
        
    }

    /**
     * Funcion para disparar una bala y destruirla después de un tiempo determinado \n
     */

    public void DispararArma()
    {
        GameObject tempBala = Instantiate(prefabBala, transform.position, transform.rotation);
        tempBala.GetComponent<Rigidbody>().velocity = tempBala.transform.forward * velocidadDisparo;
        Destroy(tempBala, distanciaDisparo / velocidadDisparo);
        fuenteDeSonido.PlayOneShot(Disparo);
    }
}
