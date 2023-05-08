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
    public GameObject FinalTrigger;
    public GameObject ManiquisRojos;

    public void Start()
    {
        AllLights = GameObject.Find("Light");
        maniquis = GameObject.Find("maniquis");
        FinalTrigger.SetActive(false);
        ManiquisRojos = GameObject.Find("ManiquisRojos");
        ManiquisRojos.SetActive(false);
    }
    private void Update()
    {
        if (activeTriggers == 5)
        {
           animator.SetBool("DoorHolder", true);
           activeTriggers = 0;
           maniquis.SetActive(false);
           FinalTrigger.SetActive(true);
        }
        else if (activeTriggers == 2)
        {
            AllLights.SetActive(false);
            maniquis.SetActive(false);
            ManiquisRojos.SetActive(true);
        }
    }
}