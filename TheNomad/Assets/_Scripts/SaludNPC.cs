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


    /**
     * Funcion para dañar al NPC y disminuir su salud máxima, \n en este caso, el npc se destruirá al \n
     * disminuir la totalidad de su vida máxima
     * 
     * _Parametros_
     * __dano__ : _el valor a disminuir de la salud actual del npc_
     * 
     */



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
