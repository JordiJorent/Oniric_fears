using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortasAscensor : MonoBehaviour
{
    public Animator animator;
    private bool doorsClosed = false;
    private bool doorsOpen = true;
    private int activeTriggers = 0; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activeTriggers++; 

            if (activeTriggers == 5 && doorsOpen)
            {
                animator.SetTrigger("closeDoors");
                doorsOpen = false;
                Invoke("RestartLevel", animator.GetCurrentAnimatorStateInfo(0).length);
            }
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        animator.SetTrigger("openDoors");
        doorsOpen = true;
    }
}