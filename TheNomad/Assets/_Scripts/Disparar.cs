using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public float velocidadDisparo = 10f;
    public float distanciaDisparo = 50f;
    public GameObject prefabBala;
    private Camera camaraDisparo;

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


    public void DispararArma()
    {
        GameObject tempBala = Instantiate(prefabBala, camaraDisparo.transform.position, camaraDisparo.transform.rotation);
        tempBala.GetComponent<Rigidbody>().velocity = camaraDisparo.transform.forward * velocidadDisparo;
        Destroy(tempBala, distanciaDisparo / velocidadDisparo);
    }
}
