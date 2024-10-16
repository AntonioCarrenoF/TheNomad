using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AdministradorVidas : MonoBehaviour
{
    public int vidasIniciales = 5;
    public Canvas canvasVidas;
    public List<GameObject> objetosVida;
    public GameObject prefabVidas;
    public GameObject menuFinJuego;


    public void Start()
    {
        objetosVida = new List<GameObject>();
        for (int i = 0; i < vidasIniciales; i++)
        {
            GameObject objetoVida = Instantiate(prefabVidas, canvasVidas.transform);
            objetosVida.Add(objetoVida);
        }
    }

    public void PerderVida()
    {
        if (objetosVida.Count > 0)
        {
            GameObject objetoVida = objetosVida.Last();
            objetosVida.Remove(objetoVida);
            Destroy(objetoVida);
            if (objetosVida.Count == 0)
            {
                menuFinJuego.SetActive(true);
            }
        }

    }

}
