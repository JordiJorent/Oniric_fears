using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  


public class MenuInicial : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip mouseFx;
    
    public void Continuar()
    {
        SceneManager.LoadScene("animacion_inicio");
        audioSource = GetComponent<AudioSource>();
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
