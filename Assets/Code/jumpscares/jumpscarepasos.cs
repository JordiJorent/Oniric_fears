using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarepasos : MonoBehaviour
{
    private AudioSource sonido;
    public GameObject jumpscare;
    public string nameOfTheSonidoGameObject;
    private void Awake()
    {
        sonido = GameObject.Find(nameOfTheSonidoGameObject).GetComponent<AudioSource>();
        sonido.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sonido.gameObject.SetActive(true);
            sonido.PlayOneShot(sonido.clip);            
            if(jumpscare != null)
                jumpscare.SetActive(true);

        }
    }
}
