using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rec_animacion : MonoBehaviour
{
    public Sprite imagenInicial;
    public Sprite imagenCambio;
    public float tiempoCambio = 10f;

    private Sprite imagenActual;

    private void Start()
    {
        StartCoroutine(CambiarImagen());
    }

    private IEnumerator CambiarImagen()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempoCambio);

            if (imagenActual == imagenInicial)
            {
                imagenActual = imagenCambio;
            }
            else
            {
                imagenActual = imagenInicial;
            }
        }
    }
}
