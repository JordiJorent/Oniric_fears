using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarepasos : MonoBehaviour
{



    public GameObject sonido;
    private AudioSource _sonido;
    public GameObject jumpscare;

    public string nameOfTheSonidoGameObject;
    private void Awake()
    {
        _sonido = GameObject.Find(nameOfTheSonidoGameObject).GetComponent<AudioSource>();
        sonido.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sonido.SetActive(true);
            Destroy(this.gameObject);
            jumpscare.SetActive(true);
            sonido.gameObject.SetActive(true);
            _sonido.PlayOneShot(_sonido.clip);
            if (jumpscare != null)
                jumpscare.SetActive(true);

        }





        /*
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
        }*/
    }
}
