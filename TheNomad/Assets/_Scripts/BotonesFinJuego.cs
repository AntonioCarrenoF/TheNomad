using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesFinJuego : MonoBehaviour
{
    public Button botonReiniciar;
    public KeyCode tecla1 = KeyCode.R;
    public Button botonMenu;
    public KeyCode tecla2 = KeyCode.M;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla1))
        {
            botonReiniciar.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla2))
        {
            botonMenu.onClick.Invoke();
        }

    }
}
