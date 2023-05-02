using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioInteractor : MonoBehaviour
{
    public GameObject Radio;
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Interactuar()
    {
        Debug.Log("interactuado con radio");
        musica.Stop();
        
    }
}
