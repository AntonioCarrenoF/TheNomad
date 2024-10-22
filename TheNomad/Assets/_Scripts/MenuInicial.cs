using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public GameObject MenuControles;
    public GameObject MenuPrincipal;

    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void FinalizarJuego()
    {
        Application.Quit();
    }

    public void MostrarControles()
    {
        MenuPrincipal.SetActive(false);
        MenuControles.SetActive(true);
    }

    public void MostrarMenuInicial()
    {
        MenuPrincipal.SetActive(true);
        MenuControles.SetActive(false);
    }

}
