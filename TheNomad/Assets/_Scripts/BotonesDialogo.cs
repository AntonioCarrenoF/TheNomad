using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesDialogo : MonoBehaviour
{
    public Button botonAmistoso;
    public KeyCode tecla1 = KeyCode.Alpha1;
    public Button botonDesagradable;
    public KeyCode tecla2 = KeyCode.Alpha2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla1))
        {
            botonAmistoso.onClick.Invoke();
        }
        if (Input.GetKeyDown(tecla2))
        {
            botonDesagradable.onClick.Invoke();
        }

    }
}
