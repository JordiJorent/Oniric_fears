using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoDePuerta : MonoBehaviour
{

    public GameObject sonido;
    private bool doOnce;
    private void Awake()
    {
        doOnce = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !doOnce)
        {
            sonido.GetComponent<AudioSource>().PlayOneShot(sonido.GetComponent<AudioSource>().clip);
            doOnce = true;
        }
    }
}
