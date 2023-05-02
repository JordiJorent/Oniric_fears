using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleApagada : MonoBehaviour
{
    public TeleEncindida teleencendida;
    public int activeTriggers = 0;
    public 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            teleencendida.Interactuar();
        }
    }
}
