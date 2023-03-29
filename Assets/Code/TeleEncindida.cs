using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleEncindida : MonoBehaviour
{
    public GameObject teleapagada;
    public Light luz;
    public Material apagado;
    public AudioSource audio;

    void Start()
    {
        luz= GetComponentInChildren<Light>();
        audio= GetComponent<AudioSource>();
        
    }
    public void Interactuar()
    {
        Debug.Log("interactuado con tele");
        luz.enabled = false;
        audio.Stop();
        GetComponentsInChildren<MeshRenderer>()[1].material= apagado;
    }

}
