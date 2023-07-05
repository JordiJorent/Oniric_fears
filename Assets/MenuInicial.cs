using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  


public class MenuInicial : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip mouseFx;
    private void Start()
    {
        if(GetComponent<AudioSource>() != null)
            audioSource = GetComponent<AudioSource>();
    }

    public void Continuar()
    {
        SceneManager.LoadScene("animacion_inicio"); 
        //SceneManager.LoadScene("DELETE");

        
    }
    public void Sortir()
    {
        Application.Quit();
    }
    public void PlaySoundFx()
    {
        audioSource.PlayOneShot(mouseFx);
    }
    
}
