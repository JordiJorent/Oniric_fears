using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortasAscensor : MonoBehaviour
{
    public Animator animator;
    private bool doorsClosed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!doorsClosed)
            {
                animator.SetTrigger("closeDoors");
                doorsClosed = true;
                Invoke("RestartLevel", animator.GetCurrentAnimatorStateInfo(0).length);
            }

        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}