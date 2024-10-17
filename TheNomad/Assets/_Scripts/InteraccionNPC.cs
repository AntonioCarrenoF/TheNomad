using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionNPC : MonoBehaviour
{
    public DialogoNPC npc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Jugador")
        {
            npc.textoDialogo.gameObject.SetActive(true);
            npc.opcion1.gameObject.SetActive(true);
            npc.opcion2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Jugador")
        {
            npc.textoDialogo.gameObject.SetActive(false);
            npc.opcion1.gameObject.SetActive(false);
            npc.opcion2.gameObject.SetActive(false);
        }

    }

}
