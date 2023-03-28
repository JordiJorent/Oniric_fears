using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleEncindida : MonoBehaviour
{
    public GameObject teleapagada;

    public void Interactuar()
    {
        Vector3 posicionTeleapagada = teleapagada.transform.position;
        teleapagada.transform.position = transform.position;
        transform.position = posicionTeleapagada;
        Destroy(gameObject);
    }

}
