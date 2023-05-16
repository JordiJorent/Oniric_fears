using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcensorCierre : MonoBehaviour
{
    public Animator animator;

    public int activeTriggers = 0;

    public GameObject AllLights;
    public GameObject FinalTrigger;

    public void Start()
    {
        AllLights = GameObject.Find("Light");
        FinalTrigger.SetActive(false);
    }
    private void Update()
    {
        if (activeTriggers == 5)
        {
            FinalTrigger.SetActive(true);
            animator.SetBool("DoorHolder", true);
            activeTriggers = 0;
        }
        else if (activeTriggers == 2)
        {
            AllLights.SetActive(false);
        }
    }
}