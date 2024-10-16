using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararNPC : Disparar
{
    private float tiempoDesdeUltimoDisparo = 1f;
    public Transform puntoDisparo;
    private Transform jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Jugador").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, jugador.position) <= distanciaDisparo && tiempoDesdeUltimoDisparo >= 1f)
        {
            DispararArma();
            tiempoDesdeUltimoDisparo = 0f;
        }
        else
        {
            tiempoDesdeUltimoDisparo += Time.deltaTime;
        }
    }

    public new void DispararArma()
    {
        GameObject bala = Instantiate(prefabBala, puntoDisparo.position, puntoDisparo.rotation);
        bala.GetComponent<Rigidbody>().velocity = (jugador.position - puntoDisparo.position).normalized * velocidadDisparo;
        Destroy(bala, distanciaDisparo / velocidadDisparo);
    }
    
}
