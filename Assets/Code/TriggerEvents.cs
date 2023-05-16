using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class TriggerEvents : MonoBehaviour
{
    public GameObject AllLights;
    public GameObject FinalTrigger;
    public Animator animator;

    public int activeTriggers = 0;

    public List<GameObject> maniquis = new List<GameObject>();
    public List<GameObject> ManiquisRojos = new List<GameObject>();
    public List<GameObject> ManiquiDesaparece = new List<GameObject>();
    public List<GameObject> ManiquisRojosPasillo = new List<GameObject>();
    public List<GameObject> ManiquisRojos5 = new List<GameObject>();

    

    // Start is called before the first frame update
    void Start()
    {
        AllLights = GameObject.Find("Light");
        

        maniquis = GameObject.FindGameObjectsWithTag("maniqui").ToList();
        ManiquisRojos = GameObject.FindGameObjectsWithTag("maniqui_rojo").ToList();
        ManiquiDesaparece = GameObject.FindGameObjectsWithTag("maniqui_desaparece").ToList();;


        for (int i = 0; i < ManiquisRojos.Count; i++)
        {
            ManiquisRojos[i].SetActive(false);
        }
        FinalTrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTriggers == 2)
        {
            AllLights.SetActive(false);
            for (int i = 0; i < ManiquiDesaparece.Count; i++)
            {
                ManiquiDesaparece[i].SetActive(false);
            }
        }
        if (activeTriggers == 5)
        {

            FinalTrigger.SetActive(true);
            animator.SetBool("DoorHolder", true);
            activeTriggers = 0;

            for (int i = 0; i < maniquis.Count; i++)
            {
                maniquis[i].SetActive(false);
            }

            for (int i = 0; i < ManiquisRojos.Count; i++)
            {
                ManiquisRojos[i].SetActive(true);
            }
        }
    }
    
    
}
