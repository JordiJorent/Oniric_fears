using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoCum : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject gameObjectToSpawn;

    private bool hasTriggered = false;

    private void OnTriggerExit(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;

            // Reproducir el audio
            audioSource.Play();

            // Esperar hasta que el audio haya terminado de reproducirse
            StartCoroutine(WaitForAudioToEnd());
        }
    }

    private IEnumerator WaitForAudioToEnd()
    {
        // Esperar hasta que el audio haya terminado de reproducirse
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        // Instanciar el GameObject después de que el audio haya terminado de reproducirse
        Instantiate(gameObjectToSpawn, transform.position, transform.rotation);
    }
}
