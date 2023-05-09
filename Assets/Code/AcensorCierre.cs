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
    public List<GameObject> maniquis = new List<GameObject>();
    public GameObject FinalTrigger;
    public List<GameObject> ManiquisRojos = new List<GameObject>();
    public List<GameObject> maniqui_desaparece = new List<GameObject>();

    public void Start()
    {
        AllLights = GameObject.Find("Light");
        maniquis = GameObject.FindGameObjectsWithTag("maniqui").ToList();
        ManiquisRojos = GameObject.FindGameObjectsWithTag("maniqui_rojo").ToList();
        maniqui_desaparece = GameObject.FindGameObjectsWithTag("maniqui_desaparece").ToList();


        FinalTrigger.SetActive(false);
        for (int i = 0; i < ManiquisRojos.Count; i++)
        {
            ManiquisRojos[i].SetActive(false);
        }
    }
    private void Update()
    {
        if (activeTriggers == 5)
        {
           animator.SetBool("DoorHolder", true);
           activeTriggers = 0;
            for (int i = 0; i < maniquis.Count; i++)
            {
                maniquis[i].SetActive(false);
            }
            FinalTrigger.SetActive(true);
        }
        else if (activeTriggers == 2)
        {
            AllLights.SetActive(false);
            for (int i = 0; i < maniquis.Count; i++)
            {
                maniquis[i].SetActive(false);
            }
            for (int i = 0; i < maniqui_desaparece.Count; i++)
            {
                maniqui_desaparece[i].SetActive(false);
            }
        }
    }
}