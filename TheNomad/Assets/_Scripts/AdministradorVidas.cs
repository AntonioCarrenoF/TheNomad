using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject balaPrefab;
    public GameObject menuFinJuego;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);

        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            EliminarVida();
        }
    }

    public void EliminarVida()
    {
        var ObjetoAEliminar = vidas[vidas.Count - 1];
        Destroy(ObjetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if (vidas.Count <= 0)
        {
            menuFinJuego.SetActive(true);
            return;
        }
        Debug.Log($"Vidas Restantes: {vidas.Count}");

    }
}
