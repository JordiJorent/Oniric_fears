using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcensorCierre : MonoBehaviour
{
    public Animator animator;
    private bool doorsClosed = false;
    private bool doorsOpen = true;
    public int activeTriggers = 0;
    private void Update()
    {
            if (activeTriggers == 5)
            {
                animator.SetBool("openDoor", true);
                activeTriggers = 0;
            }
    }
}