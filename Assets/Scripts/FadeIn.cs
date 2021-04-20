using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Reproduce el efecto de fade-in en la escena
 * Autor: Roberto Mtz. Román
 */
public class FadeIn : MonoBehaviour
{
    // La imagenFondo
    public Image imagenFondo;

    // Start is called before the first frame update
    void Start()
    {
        // Se hace completamente transparente en 2 seg.
        imagenFondo.CrossFadeAlpha(0, 0.7f, true);
    }
}
