using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioDeEscena : MonoBehaviour
{
    public string sceneName; // El nombre de la escena a la que quieres cambiar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el jugador tiene un tag "Player"
        {
            SceneManager.LoadScene(sceneName); // Cambia a la escena especificada por sceneName
        }
    }



}
