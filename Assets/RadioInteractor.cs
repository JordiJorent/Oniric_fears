using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioInteractor : MonoBehaviour
{
    public GameObject Radio;
    public AudioSource musica;
    public AudioSource apagarTeleFx;
    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Interactuar()
    {
        if (musica.isPlaying)
        {
            musica.Pause();
            OnShutDownTv();
        }
        else 
        {
            musica.UnPause();
            OnShutDownTv();
        }
        void OnShutDownTv()
        {
            apagarTeleFx.PlayOneShot(apagarTeleFx.clip);
        }



    }
}
