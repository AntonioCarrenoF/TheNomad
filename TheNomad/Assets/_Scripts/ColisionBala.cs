using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBala : MonoBehaviour
{
    public AdministradorVidas referenciaVidas;

    // Start is called before the first frame update
    void Start()
    {
        referenciaVidas = GameObject.FindGameObjectWithTag("Jugador").GetComponent<AdministradorVidas>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            referenciaVidas.EliminarVida();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
