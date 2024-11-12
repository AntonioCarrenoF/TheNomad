using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionPrimera : MonoBehaviour
{
    public GameObject objetoRecolectar;
    public GameObject menuGanado;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objetoRecolectar)
        {
            menuGanado.SetActive(true);
            Destroy(objetoRecolectar);
        }
    }

}
