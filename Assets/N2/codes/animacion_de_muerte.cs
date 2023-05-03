using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion_de_muerte : MonoBehaviour
{
    public Camera cam;
    public FirstPersonController controller;
    public Transform emenyHead;
    public Transform startPosition;
    public Transform player;
    public Animator anim;
    public Transform enemyStartPosition;
    public Transform enemy;
    [SerializeField] private AudioSource silbidoAudioLoop;
    [SerializeField] private AudioSource gritoAudioSource;
    [SerializeField] private AudioClip grito;
    [SerializeField] private AudioClip silbido;
    public float esperarAQueElSonidoDelGritoTermine;
    private void Start()
    {
        gritoAudioSource.enabled = false;
    }
    public void StartDeadAnimation()
    {
        controller.playerCanMove = false;
        controller.cameraCanMove = false;
        cam.transform.LookAt(emenyHead);

    }
    public void EndDeadAnimation()
    {
        controller.playerCanMove = true;
        controller.cameraCanMove = true;
        player.transform.position = startPosition.transform.position;
        enemy.transform.position = enemyStartPosition.position;
        anim.SetBool("m", false);
    }
    public void ReproducirGrito()
    {
        silbidoAudioLoop.enabled = false;
        gritoAudioSource.enabled = true;
        StartCoroutine(EsperarAQueElSonidoDelGritoTermine(esperarAQueElSonidoDelGritoTermine));
    }
    IEnumerator EsperarAQueElSonidoDelGritoTermine(float s)
    {
        yield return new WaitForSeconds(s);
        silbidoAudioLoop.enabled = true;
        gritoAudioSource.enabled = false;
        
    }





}
