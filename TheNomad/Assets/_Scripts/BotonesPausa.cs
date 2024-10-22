using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesPausa : MonoBehaviour
{
    public Button botonMenu;
    public KeyCode tecla1 = KeyCode.M;
    public Button botonReanudar;
    public KeyCode tecla2 = KeyCode.R;
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
            botonMenu.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla2))
        {
            botonReanudar.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla3))
        {
            botonSalir.onClick.Invoke();
        }

    }
}
