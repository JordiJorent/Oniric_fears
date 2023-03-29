using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    public GameObject AllLights;
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
