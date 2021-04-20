using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Controla el menú.
 * Agregamos los métodos para atender los componentes del menú
 * Autor: Roberto Mtz. Román
 */
public class Menu : MonoBehaviour
{
    // Imagen de fondo
    public Image imagenFondo;

    public void Salir()
    {
        // Regresa al Sistema Operativo
        Application.Quit();
    }
    
    public void IniciarJuego()
    {
        // Efecto Fade-Out
        imagenFondo.canvasRenderer.SetAlpha(0);
        imagenFondo.gameObject.SetActive(true);
        imagenFondo.CrossFadeAlpha(1, 0.7f, true);

        StartCoroutine(CambiarEscena());

        // CAMBIAR escena
        //SceneManager.LoadScene("EscenaMapa");
    }

    private IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(0.7f);

        // Ya regresó/terminó
        SceneManager.LoadScene("EscenaMapa");
    }
}
