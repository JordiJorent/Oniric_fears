using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class animacion : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nombreDeLaEscena;

    private void Start()
    {
        videoPlayer.loopPointReached += CambiarEscena;
    }
    private void CambiarEscena(VideoPlayer vp)
    {
        SceneManager.LoadScene(nombreDeLaEscena);



    }



}