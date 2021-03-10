using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Controla el menú.
 * Agregamos los métodos para atender los componentes del menú
 * Autor: Roberto Mtz. Román
 */
public class Menu : MonoBehaviour
{

    public void Salir()
    {
        // Regresa al Sistema Operativo
        Application.Quit();
    }
    
    public void IniciarJuego()
    {
        // Cambiar de escena
        //print("Click al botón");
        
        // CAMBIAR escena
        SceneManager.LoadScene("EscenaMapa");
    }
}
