using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesMenuPrincipal : MonoBehaviour
{
    public Button botonIniciar;
    public KeyCode tecla1 = KeyCode.I;
    public Button botonControles;
    public KeyCode tecla2 = KeyCode.C;
    public Button botonSalir;
    public KeyCode tecla3 = KeyCode.Q;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla1))
        {
            botonIniciar.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla2))
        {
            botonControles.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla3))
        {
            botonSalir.onClick.Invoke();
        }

    }
}
