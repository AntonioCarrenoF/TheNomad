using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdministradorVidas : MonoBehaviour
{
    public int vidasIniciales = 5;
    public GameObject menuFinJuego;
    private int vidasActuales;


    public void Start()
    {
        vidasActuales = vidasIniciales;
    }

    public void PerderVida()
    {
        vidasActuales--;
        if (vidasActuales <= 0)
        {
            PerderJuego();
        }
    }


    private void PerderJuego()
    {
        menuFinJuego.SetActive(true);
    }

}
