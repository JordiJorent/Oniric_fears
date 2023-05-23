using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TeleEncindida : MonoBehaviour
{
    public GameObject teleapagada;
    public Light luz;
    public Material apagado;
    public AudioSource staticaudio;
    public AudioSource apagarTeleFx;


    void Start()
    {
        luz= GetComponentInChildren<Light>();
        staticaudio = GetComponent<AudioSource>();
    }
    public void Interactuar()
    {
        luz.enabled = false;
        staticaudio.Stop();
        GetComponentsInChildren<MeshRenderer>()[1].material= apagado;
        OnShutDownTv();
    }
    void OnShutDownTv()
    {
        apagarTeleFx.PlayOneShot(apagarTeleFx.clip);
    }

}
