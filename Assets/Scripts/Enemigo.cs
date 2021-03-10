using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(other.gameObject, 0.3f);
        }
    }
}
