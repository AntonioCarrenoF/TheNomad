using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public float velocidadDisparo = 10f;
    public float distanciaDisparo = 50f;
    public GameObject prefabBala;
    private Camera camaraDisparo;
    public int dano = 1;

    // Start is called before the first frame update
    void Start()
    {
        camaraDisparo = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DispararArma();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NPCEnemigo")
        {
            SaludNPC saludNPC = collision.gameObject.GetComponent<SaludNPC>();
            saludNPC.RecibirDano(dano);

        }
    }


    public void DispararArma()
    {
        GameObject tempBala = Instantiate(prefabBala, camaraDisparo.transform.position, camaraDisparo.transform.rotation);
        tempBala.GetComponent<Rigidbody>().velocity = camaraDisparo.transform.forward * velocidadDisparo;
        Destroy(tempBala, distanciaDisparo / velocidadDisparo);
    }
}
