using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Detecta la colisión del enemigo con el personaje
 * Autor: Roberto Mtz. Román
 */
public class Enemigo : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Descontar una vida
            SaludPersonaje.instance.vidas--;
            // Actualizar los 'corazones'
            HUD.instance.ActualizarVidas();
            if (SaludPersonaje.instance.vidas == 0)
            {
                Destroy(other.gameObject, 0.3f);
                SceneManager.LoadScene("EscenaMenu");   // Pierde, regresa al menú
            }
        }
    }
}
