using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesUI : MonoBehaviour
{
    public Button botonPausa;
    public KeyCode tecla1 = KeyCode.P;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla1))
        {
            botonPausa.onClick.Invoke();
        }
    }
}
