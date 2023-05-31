using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SonidoCum : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject enemy;
    private Vector3 col;
    private GameObject player;
    private bool hasTriggered = false;
    private void Awake()
    {
        player = GameObject.Find("FirstPersonControllerN2");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, player.transform.position - transform.position, out hit))
            {
                col = hit.point;
            }
        }
    }
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

        // Mover al enemigo de la escena a esta posicion
        if(col != null)
        {
            if(GameObject.FindGameObjectsWithTag("Enemigo").ToList().Count == 0)
            {
                Instantiate(enemy, col, Quaternion.identity);
            }            
        }        
    }
}
