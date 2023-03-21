using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject lightGO; //light gameObject to work with
    private bool isOn = false; //is flashlight on or off?

    // Use this for initialization
    void Start()
    {
        lightGO.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            
            if (isOn)
            {
                lightGO.SetActive(true);
            }
            else
            {
                lightGO.SetActive(false);

            }
        }
    }
}
