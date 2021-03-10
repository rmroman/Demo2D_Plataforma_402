using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Detecta la colisión de la moneda con el personaje
 * Autor: Roberto Mtz. Román
 */
public class Moneda : MonoBehaviour
{
    // La moneda colisionó con otro objeto (colliders)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Recolectar
            // Dejar de dibujar a moneda
            GetComponent<SpriteRenderer>().enabled = false;
            // Prender la explosión
            // moneda.transform.hijo del transform(transform de la explosion).explosion.Se hace activa
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            
            Destroy(gameObject, 0.5f);
        }
    }
}
