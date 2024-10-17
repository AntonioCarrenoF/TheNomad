using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogoNPC : MonoBehaviour
{
    public TextMeshProUGUI textoDialogo;
    public Button opcion1;
    public Button opcion2;
    public string dialogoInicial="Hola, ¿qué te trae por Landfield?";
    public string opcion1Texto = "Deseo explorar el lugar, se ve que hay cosas muy interesantes por descubrir";
    public string opcion2Texto = "No es de tu incumbencia";
    public string dialogoOpcion1 = "Es correcto, bienvenido, solamente ten cuidado en tu aventura, no todos somos amistosos y algunas personas podrían herirte, suerte!!!";
    public string dialogoOpcion2 = "Tienes suerte que no estoy en humor de pelear, sin embargo, no siempre tendrás la misma suerte, largo de aquí!!!";

    // Start is called before the first frame update
    void Start()
    {
        textoDialogo.text = dialogoInicial;
        opcion1.onClick.AddListener(Opcion1);
        opcion2.onClick.AddListener(Opcion2);

    }

    public void Opcion1()
    {
        textoDialogo.text = dialogoOpcion1;
    }

    public void Opcion2()
    {
        textoDialogo.text = dialogoOpcion2;
    }


}
