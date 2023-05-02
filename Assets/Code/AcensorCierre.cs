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
    public GameObject AllLights;
    public GameObject maniquis;

    public void Start()
    {
        AllLights = GameObject.Find("Light");
    }
    private void Update()
    {
        if (activeTriggers == 5)
        {
           animator.SetBool("openDoor", true);
           activeTriggers = 0;
            maniquis.SetActive(false);
        }
        else if (activeTriggers == 2)
        {
            AllLights.SetActive(false);
        }
    }
}