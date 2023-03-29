using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class TriggerEvents : MonoBehaviour
{
    public GameObject AllLights;
    public AcensorCierre tmp; 
    // Start is called before the first frame update
    void Start()
    {
        AllLights = GameObject.Find("Light");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CustomEvent()
    {
        switch (gameObject.name)
        {
            case "ApagarLuz":
                TurnOfLights();
                break;
            case "EncenderLuz":
                TurnOnLights();
                break;
            default:

                tmp.activeTriggers++;
                Debug.Log(tmp.activeTriggers);
                break;
        }
    }
    public void TurnOfLights()
    {
        AllLights.SetActive(false);
    }
    public void TurnOnLights()
    {
        AllLights.SetActive(true);
    }
}
