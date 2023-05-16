using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManiquisManager : MonoBehaviour
{
    public int activeTriggers = 0;


    public List<GameObject> maniquis = new List<GameObject>();
    public List<GameObject> ManiquisRojos = new List<GameObject>();
    public List<GameObject> maniqui_desaparece = new List<GameObject>();
    public List<GameObject> ManiquisRojosPasillo = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        maniquis = GameObject.FindGameObjectsWithTag("maniqui").ToList();
        ManiquisRojos = GameObject.FindGameObjectsWithTag("maniqui_rojo").ToList();
        maniqui_desaparece = GameObject.FindGameObjectsWithTag("maniqui_desaparece").ToList();
        ManiquisRojosPasillo = GameObject.FindGameObjectsWithTag("maniquirojopasillo").ToList();

        for (int i = 0; i < ManiquisRojos.Count; i++)
        {
            ManiquisRojos[i].SetActive(false);
        }
        for (int i = 0; i < ManiquisRojos.Count; i++)
        {
            ManiquisRojosPasillo[i].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTriggers == 1)
        {

        }
        if (activeTriggers == 2)
        {
            for (int i = 0; i < maniqui_desaparece.Count; i++)
            {
                maniqui_desaparece[i].SetActive(false);
            }
            for (int i = 0; i < ManiquisRojos.Count; i++)
            {
                ManiquisRojos[i].SetActive(true);
            }
        }
        if (activeTriggers == 3)
        {

        }
        if (activeTriggers == 4)
        {

        }
        if (activeTriggers == 5)
        {
            for (int i = 0; i < maniquis.Count; i++)
            {
                maniquis[i].SetActive(false);
            }
            
            for (int i = 0; i < ManiquisRojosPasillo.Count; i++)
            {
                ManiquisRojosPasillo[i].SetActive(true);
            }
        }



    }
}
