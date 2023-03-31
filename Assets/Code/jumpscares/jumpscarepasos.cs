using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarepasos : MonoBehaviour
{
    public GameObject sonido;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sonido.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
