using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludNPC : MonoBehaviour
{
    public int saludMaxima = 5;
    public int saludActual;

    // Start is called before the first frame update
    void Start()
    {
        saludActual = saludMaxima;
    }

    public void RecibirDano(int dano)
    {
        saludActual -= dano;

        if (saludActual <= 0)
        {
            MuerteNPC();
        }
    }

    public void MuerteNPC()
    {
        Destroy(this.gameObject);
    }

}
