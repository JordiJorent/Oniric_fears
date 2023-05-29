using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class animacion : MonoBehaviour

{
    Vector3 AnteriorPosition;
    public VideoPlayer videoPlayer;
    public string nombreDeLaEscena;
    public GameObject Boton;
    float TemporizadorActual;
    public float TiempoMaximo;



    private void Start()
    {
        TemporizadorActual = 0.0f;
        videoPlayer.loopPointReached += CambiarEscena;
        AnteriorPosition = Input.mousePosition;
        Boton.SetActive(false);

    }

    private void Update()
    {
        if (videoPlayer.isPlaying)
        {
            if (Boton.activeSelf)
            {
                TemporizadorActual += Time.deltaTime;
                if (TemporizadorActual >= TiempoMaximo)
                {
                    Boton.SetActive(false);
                    TemporizadorActual = 0.0f;
                }
            }


            if (Input.mousePosition != AnteriorPosition)
            {
                AnteriorPosition = Input.mousePosition;
                Boton.SetActive(true);
                TemporizadorActual = 0.0f;
            }


        }

    }
    public void CambiarEscena(VideoPlayer vp)
    {
        SceneManager.LoadScene(nombreDeLaEscena);



    }


}

