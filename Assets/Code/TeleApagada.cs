using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleApagada : MonoBehaviour
{
    public TeleEncindida teleencendida;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            teleencendida.Interactuar();
        }
    }
}
