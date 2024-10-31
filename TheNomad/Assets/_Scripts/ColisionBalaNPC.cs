using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBalaNPC : MonoBehaviour
{
    public GameObject particulasExplosion;
    public int dano = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NPCEnemigo")
        {
            SaludNPC saludNPC = collision.gameObject.GetComponent<SaludNPC>();
            saludNPC.RecibirDano(dano);
            GameObject particulas = Instantiate(particulasExplosion, transform.position, Quaternion.identity) as GameObject;

        }
    }
}
