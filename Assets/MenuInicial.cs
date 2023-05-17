using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicial : MonoBehaviour
{
    public void Continuar()
    {
        SceneManager.LoadScene("animacion_inicio");
    }

    public void Sortir()
    {
        Debug.Log("Sortir...");
        Application.Quit();

    }
    
}
