using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Mtz. Román
 * prueba si el collider está DENTRO o FUERA de una plataforma
 */
public class PruebaPiso : MonoBehaviour
{
    public static bool estaEnPiso = false;

    // Se ejecuta cuando el collider ENTRA a otro collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Moneda")
        {
            estaEnPiso = true;
        }

        //print("Está en piso");
    }

    // Se ejecuta cuando el collider SALE a otro collider
    private void OnTriggerExit2D(Collider2D other)
    {
        estaEnPiso = false;
        //print("No está en piso");
    }
}
