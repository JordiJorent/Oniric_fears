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





}
