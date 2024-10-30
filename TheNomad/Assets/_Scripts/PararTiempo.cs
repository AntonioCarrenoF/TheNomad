using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoParado : MonoBehaviour
{
    public Camera camara;
    private Vector3 posicion;
    private Quaternion rotacion;

    private void OnEnable()
    {
        Time.timeScale = 0.0f;
        posicion = camara.transform.position;
        rotacion = camara.transform.rotation;
    }

    private void Update()
    {
        camara.transform.position = posicion;
        camara.transform.rotation = rotacion;
    }

    private void OnDisable()
    {
        Time.timeScale = 1.0f;
    }

}
