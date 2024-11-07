using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarSalud : MonoBehaviour
{
    public int saludRecuperada = 10;
    public AdministradorVidas administradorVidas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            administradorVidas.GanarVida(saludRecuperada);
            Destroy(gameObject);

        }
    }

}
